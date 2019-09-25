using System;
using System.Collections.Generic;
using System.Threading;
using System.Reflection;
using System.ComponentModel;
using System.IO;
using SteamKit2;
using SteamKit2.Discovery;
using SteamKit2.Internal;

namespace HourBoostr
{
    class Session
    {
        /// <summary>
        /// List of active bot accounts
        /// </summary>
        public List<Bot> mActiveBotList { get; set; } = new List<Bot>();


        /// <summary>
        /// Session background worker
        /// </summary>
        public BackgroundWorker mBwg = new BackgroundWorker();


        /// <summary>
        /// Application settings
        /// </summary>
        public Config.Settings mSettings;


        /// <summary>
        /// Thread for updating title status
        /// </summary>
        private Thread mThreadStatus;


        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="settings"></param>
        public Session(Config.Settings settings)
        {
            mSettings = settings;

            if (settings.CheckForUpdates && Update.IsUpdateAvailable())
                if (Thread.CurrentThread.CurrentCulture.Name.StartsWith("fr"))
                {
                    Console.WriteLine("Il y a une mise à jour disponible. Vérifier sur https://github.com/xnooztvFR/EZBooster-V3/releases \n Pause pendant 10 secondes");
                    Thread.Sleep(10000);
                } else
                {
                    Console.WriteLine("There is an update available. Go to https://github.com/xnooztvFR/EZBooster-V3/releases \n Sleeping for 10 seconds.");
                    Thread.Sleep(10000);
                }

            mBwg.DoWork += MBwg_DoWork;
            mBwg.RunWorkerAsync();
        }


        /// <summary>
        /// Backgroundworker to start all bots
        /// </summary>
        private void MBwg_DoWork(object sender, DoWorkEventArgs e)
        {
            /*Go through account and log them into steam*/
            foreach (var account in mSettings.Accounts)
            {
                if (account.IgnoreAccount)
                {
                    if (Thread.CurrentThread.CurrentCulture.Name.StartsWith("fr"))
                    {
                        Console.WriteLine($"{account.Details.Username} a été ignoré.");
                    } else
                    {
                        Console.WriteLine($"{account.Details.Username} was ignored.");
                    }
                    continue;
                }

                var bot = new Bot(account);
                mActiveBotList.Add(bot);

                /*We'll wait for the bot to log in before starting on the next bot
                We won't wait for it to authenticate, should that be enabled*/
                while (bot.mBotState == Bot.BotState.LoggedOut)
                    Thread.Sleep(100);
            }

            /*Accounts statistics and some fucking baller ascii*/
            if (Thread.CurrentThread.CurrentCulture.Name.StartsWith("fr")) 
            {
                Console.Clear();
                Console.WriteLine($"\n  ███████╗███████╗██████╗  ██████╗  ██████╗ ███████╗████████╗███████╗██████╗     ██╗   ██╗██████╗ ");
                Console.WriteLine($"  ██╔════╝╚══███╔╝██╔══██╗██╔═══██╗██╔═══██╗██╔════╝╚══██╔══╝██╔════╝██╔══██╗    ██║   ██║╚════██╗");
                Console.WriteLine($"  █████╗    ███╔╝ ██████╔╝██║   ██║██║   ██║███████╗   ██║   █████╗  ██████╔╝    ██║   ██║ █████╔╝");
                Console.WriteLine($"  ██╔══╝   ███╔╝  ██╔══██╗██║   ██║██║   ██║╚════██║   ██║   ██╔══╝  ██╔══██╗    ╚██╗ ██╔╝ ╚═══██╗");
                Console.WriteLine($"  ███████╗███████╗██████╔╝╚██████╔╝╚██████╔╝███████║   ██║   ███████╗██║  ██║     ╚████╔╝ ██████╔╝");
                Console.WriteLine($"  ╚══════╝╚══════╝╚═════╝  ╚═════╝  ╚═════╝ ╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝      ╚═══╝  ╚═════╝\n");
                Console.WriteLine($"  Source: https://github.com/xnooztvFR/EZBooster-V3");
                Console.WriteLine($"  Date de compilation: {File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location)}");
                Console.WriteLine($"  Version: {Utils.GetVersion()}\n");
                Console.WriteLine($"  ----------------------------------------");
                Console.WriteLine($"\n  Il y à {mActiveBotList.Count} compte(s) chargé\n\n  Liste des comptes:");
                mActiveBotList.ForEach(o => Console.WriteLine("      {0} | {1} Jeux", o.mAccountSettings.Details.Username, o.mSteam.games.Count));
                Console.WriteLine($"\n\n  Journaux:\n  ----------------------------------------\n");
            } else
            {
                Console.Clear();
                Console.WriteLine($"\n  ███████╗███████╗██████╗  ██████╗  ██████╗ ███████╗████████╗███████╗██████╗     ██╗   ██╗██████╗ ");
                Console.WriteLine($"  ██╔════╝╚══███╔╝██╔══██╗██╔═══██╗██╔═══██╗██╔════╝╚══██╔══╝██╔════╝██╔══██╗    ██║   ██║╚════██╗");
                Console.WriteLine($"  █████╗    ███╔╝ ██████╔╝██║   ██║██║   ██║███████╗   ██║   █████╗  ██████╔╝    ██║   ██║ █████╔╝");
                Console.WriteLine($"  ██╔══╝   ███╔╝  ██╔══██╗██║   ██║██║   ██║╚════██║   ██║   ██╔══╝  ██╔══██╗    ╚██╗ ██╔╝ ╚═══██╗");
                Console.WriteLine($"  ███████╗███████╗██████╔╝╚██████╔╝╚██████╔╝███████║   ██║   ███████╗██║  ██║     ╚████╔╝ ██████╔╝");
                Console.WriteLine($"  ╚══════╝╚══════╝╚═════╝  ╚═════╝  ╚═════╝ ╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝      ╚═══╝  ╚═════╝\n");
                Console.WriteLine($"  Source: https://github.com/xnooztvFR/EZBooster-V3");
                Console.WriteLine($"  Build date: {File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location)}");
                Console.WriteLine($"  Version: {Utils.GetVersion()}\n");
                Console.WriteLine($"  ----------------------------------------");
                Console.WriteLine($"\n  There is {mActiveBotList.Count} accounts loaded\n\n  List of accounts:");
                mActiveBotList.ForEach(o => Console.WriteLine("      {0} | {1} Games", o.mAccountSettings.Details.Username, o.mSteam.games.Count));
                Console.WriteLine($"\n\n  Log:\n  ----------------------------------------\n");
            }

            /*Start status thread*/
            mThreadStatus = new Thread(ThreadStatus);
            mThreadStatus.Start();

            if (mSettings.HideToTray)
            {

            }
        }

        private void HideAppToTray()
        {
            
        }


        /// <summary>
        /// Returns the DateTime of when the application was built
        /// </summary>
        /// <returns>DateTime</returns>
        private DateTime GetBuildDate()
        {
            var version = Assembly.GetEntryAssembly().GetName().Version;
            return new DateTime(2000, 1, 1).Add(new TimeSpan(
                TimeSpan.TicksPerDay * version.Build +
                TimeSpan.TicksPerSecond * 2 * version.Revision));
        }


        /// <summary>
        /// Status for how long the bot has been running
        /// </summary>
        private void ThreadStatus()
        {
            var initializedTime = DateTime.Now;

            while (true)
            {
                /*Get the current time then subtract the time when all bots were done initializing*/
                /*This will give us an idea of how long the bot has been running*/
                TimeSpan timeSpan = DateTime.Now - initializedTime;
                if (Thread.CurrentThread.CurrentCulture.Name.StartsWith("fr"))
                {
                    string timeSpentOnline = string.Format("{0} Heures {1} Minutes {2} Secondes",
                    (timeSpan.Days * 24) + timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);

                    Console.Title = $"{EndPoint.CONSOLE_TITLE} | En ligne depuis: {timeSpentOnline}";
                    Thread.Sleep(500);
                } else
                {
                    string timeSpentOnline = string.Format("{0} Hours {1} Minutes {2} Seconds",
                    (timeSpan.Days * 24) + timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);

                    Console.Title = $"{EndPoint.CONSOLE_TITLE} | Online since: {timeSpentOnline}";
                    Thread.Sleep(500);
                }
            }
        }
    }
}