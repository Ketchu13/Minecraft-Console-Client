using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace MinecraftClientGUI
{
    /// <summary>
    /// This class acts as a wrapper for MinecraftClient.exe
    /// Allows the rest of the program to consider this class as the Minecraft client itself.
    /// </summary>

    class MinecraftClient
    {
        public static string ExePath = "MinecraftClient.exe";
        public bool Disconnected { get { return disconnected; } }

        LinkedList<string> outputBuffer = new LinkedList<string>();
        LinkedList<string> tabAutoCompleteBuffer = new LinkedList<string>();
        bool disconnected = false;
        Process client;
        Thread reader;

        /// <summary>
        /// Start a client using command-line arguments
        /// </summary>
        /// <param name="args">Arguments to pass</param>        
        public MinecraftClient(string[] args)
        {
            InitClient("\"" + String.Join("\" \"", args) + "\" BasicIO");
        }

        /// <summary>
        /// Start the client using username, password and server IP
        /// </summary>
        /// <param name="username">Username or email</param>
        /// <param name="password">Password for the given username</param>
        /// <param name="serverip">Server IP to join</param>
        public MinecraftClient(string username, string password, string serverip)
        {
            InitClient('"' + username + "\" \"" + password + "\" \"" + serverip + "\" BasicIO");
        }

        /// <summary>
        /// Inner function for launching the external console application
        /// </summary>
        /// <param name="arguments">Arguments to pass</param>

        private void InitClient(string arguments)
        {
            if (File.Exists(ExePath))
            {
                client = new Process();
                client.StartInfo.FileName = ExePath;
                client.StartInfo.Arguments = arguments;
                client.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                client.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ANSICodePage);
                client.StartInfo.UseShellExecute = false;
                client.StartInfo.RedirectStandardOutput = true;
                client.StartInfo.RedirectStandardInput = true;
                client.StartInfo.CreateNoWindow = true;
                client.Start();

                reader = new Thread(new ThreadStart(TRreader));
                reader.Start();
            }
            else throw new FileNotFoundException("Cannot find Minecraft Client Executable!", ExePath);
        }

        /// <summary>
        /// Thread for reading output and app messages from the console
        /// </summary>

        private void TRreader()
        {
            while (true)
            {
                try
                {
                    string line = "";
                    while (line.Trim() == "")
                    {
                        line = client.StandardOutput.ReadLine() + client.MainWindowTitle;
                        if (line.Length > 0)
                        {
                            if (line == "Server was successfuly joined.") { disconnected = false; }
                            if (line == "You have left the server.") { disconnected = true; }
                            if (line[0] == (char)0x00)
                            {
                                //App message from the console
                                string[] command = line.Substring(1).Split((char)0x00);
                                switch (command[0].ToLower())
                                {
                                    case "autocomplete":
                                        if (command.Length > 1) { tabAutoCompleteBuffer.AddLast(command[1]); }
                                        else tabAutoCompleteBuffer.AddLast("");
                                        break;
                                }
                            }
                            else outputBuffer.AddLast(line);
                        }
                    }
                }
                catch (NullReferenceException) { break; }
            }
        }

        /// <summary>
        /// Get the first queuing output line to print
        /// </summary>
        /// <returns></returns>

        public string ReadLine()
        {
            while (outputBuffer.Count < 1) { }
            string line = outputBuffer.First.Value;
            outputBuffer.RemoveFirst();
            return line;
        }

        /// <summary>
        /// Complete a playername or a command, usually by pressing the TAB key
        /// </summary>
        /// <param name="textBehindcursor">Text to complete</param>
        /// <returns>Returns an autocompletion for the provided text</returns>

        public string TabAutoComplete(string textBehindcursor)
        {
            tabAutoCompleteBuffer.Clear();
            if (textBehindcursor != null && textBehindcursor.Trim().Length > 0)
            {
                textBehindcursor = textBehindcursor.Trim();
                SendText((char)0x00 + "autocomplete" + (char)0x00 + textBehindcursor);
                int maxwait = 30; while (tabAutoCompleteBuffer.Count < 1 && maxwait > 0) { Thread.Sleep(100); maxwait--; }
                if (tabAutoCompleteBuffer.Count > 0)
                {
                    string textCompleted = tabAutoCompleteBuffer.First.Value;
                    tabAutoCompleteBuffer.RemoveFirst();
                    return textCompleted;
                }
                else return textBehindcursor;
            }
            else return "";
        }

        /// <summary>
        /// Send a message or a command to the server
        /// </summary>
        /// <param name="text">Text to send</param>

        public void SendText(string text)
        {
            if (text != null)
            {
                text = text.Replace("\t", "");
                text = text.Replace("\r", "");
                text = text.Replace("\n", "");
                text = text.Trim();
                if (text.Length > 0)
                {
                    client.StandardInput.WriteLine(text);
                }
            }
        }

        /// <summary>
        /// Properly disconnect from the server and dispose the client
        /// </summary>

        public void Close()
        {
            client.StandardInput.WriteLine("/quit");
            if (reader.IsAlive) { reader.Abort(); }
            if (!client.WaitForExit(3000))
            {
                try { client.Kill(); } catch { }
            }
        }
    }
}
