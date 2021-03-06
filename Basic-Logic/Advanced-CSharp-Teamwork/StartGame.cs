﻿using System;
using System.Threading;

namespace Advanced_CSharp_Teamwork
{
    class StartGame
    {
        public static void Start()
        {
            Thread th = new Thread(Music);
            th.Start();
            Console.CursorVisible = false;
            //Console.SetWindowSize(88, 24);
            Console.WriteLine(@"             


                          .___________. _______     ___      .___  ___.                      
                          |           ||   ____|   /   \     |   \/   |                      
                          `---|  |----`|  |__     /  ^  \    |  \  /  |                      
                              |  |     |   __|   /  /_\  \   |  |\/|  |                      
                              |  |     |  |____ /  _____  \  |  |  |  |                      
                              |__|     |_______/__/     \__\ |__|  |__|                      
                                                                                             
                          ____    ____  ______        _______.     _______.                  
                          \   \  /   / /  __  \      /       |    /       |                  
                           \   \/   / |  |  |  |    |   (----`   |   (----`                  
                            \      /  |  |  |  |     \   \        \   \                      
                             \    /   |  `--'  | .----)   |   .----)   |                     
                              \__/     \______/  |_______/    |_______/                      
                                                                                             
       ______   .______       _______     _______. _______ .__   __. .___________.    _______.
      |   _  \  |   _  \     |   ____|   /       ||   ____||  \ |  | |           |   /       |
      |  |_)  | |  |_)  |    |  |__     |   (----`|  |__   |   \|  | `---|  |----`  |   (----`
      |   ___/  |      /     |   __|     \   \    |   __|  |  . `  |     |  |        \   \    
      |  |      |  |\  \----.|  |____.----)   |   |  |____ |  |\   |     |  |    .----)   |   
      | _|      | _| `._____||_______|_______/    |_______||__| \__|     |__|    |_______/    
                                                                                            ");
                 Thread.Sleep(5000);
      
                 Console.Clear();
            //Console.SetWindowSize(76, 22);

            Console.WriteLine(@"

                       
                         .______    __    __   __       __          _______. 
                         |   _  \  |  |  |  | |  |     |  |        /       | 
                         |  |_)  | |  |  |  | |  |     |  |       |   (----` 
                         |   _  <  |  |  |  | |  |     |  |        \   \     
                         |  |_)  | |  `--'  | |  `----.|  `----.----)   |    
                         |______/   \______/  |_______||_______|_______/     
                                                                             
                                       ___      .__   __.  _______           
                                      /   \     |  \ |  | |       \          
                                     /  ^  \    |   \|  | |  .--.  |         
                                    /  /_\  \   |  . `  | |  |  |  |         
                                   /  _____  \  |  |\   | |  '--'  |         
                                  /__/     \__\ |__| \__| |_______/          
                                                                             
                              ______   ______   ____    __    ____   _______.
                             /      | /  __  \  \   \  /  \  /   /  /       |
                            |  ,----'|  |  |  |  \   \/    \/   /  |   (----`
                            |  |     |  |  |  |   \            /    \   \    
                            |  `----.|  `--'  |    \    /\    / .----)   |   
                             \______| \______/      \__/  \__/  |_______/      
                                                               ");
            Thread.Sleep(3000);
            Console.Clear();
            ShowMenu();
            th.Abort();
        }

        public static void ShowMenu()
        {
            Console.WriteLine(@"


          
                 __          ___      .______    __          ___   ____    ____    
                /_ |         \  \     |   _  \  |  |        /   \  \   \  /   /    
                 | |     _____\  \    |  |_)  | |  |       /  ^  \  \   \/   /     
                 | |    |______>  >   |   ___/  |  |      /  /_\  \  \_    _/      
                 | |          /  /    |  |      |  `----./  _____  \   |  |        
                 |_|         /__/     | _|      |_______/__/     \__\  |__|        
                                                                                   
                 ___           ___       __    __   _______  __      .______       
                | _ \          \  \     |  |  |  | |   ____||  |     |   _  \      
                   ) |     _____\  \    |  |__|  | |  |__   |  |     |  |_)  |     
                  / /     |______>  >   |   __   | |   __|  |  |     |   ___/      
                 / /_           /  /    |  |  |  | |  |____ |  `----.|  |          
                |____|         /__/     |__|  |__| |_______||_______|| _|          
                                                                                   
                 ____           ___        ______      __    __   __  .___________.
                |___ \          \  \      /  __  \    |  |  |  | |  | |           |
                  __) |     _____\  \    |  |  |  |   |  |  |  | |  | `---|  |----`
                 |__ <     |______>  >   |  |  |  |   |  |  |  | |  |     |  |     
                 ___) |          /  /    |  `--'  '--.|  `--'  | |  |     |  |     
                |____/          /__/      \_____\_____\\______/  |__|     |__|    ");
        }

        private static void Music()
        {
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(932, 150);
            Thread.Sleep(150);
            Console.Beep(1047, 150);
            Thread.Sleep(150);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(699, 150);
            Thread.Sleep(150);
            Console.Beep(740, 150);
            Thread.Sleep(150);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(932, 150);
            Thread.Sleep(150);
            Console.Beep(1047, 150);
            Thread.Sleep(150);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(699, 150);
            Thread.Sleep(150);
            Console.Beep(740, 150);
            Thread.Sleep(150);
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(587, 1200);
            Thread.Sleep(75);
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(554, 1200);
            Thread.Sleep(75);
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(523, 1200);
            Thread.Sleep(150);
            Console.Beep(466, 150);
            Console.Beep(523, 150);
        }
    }
}