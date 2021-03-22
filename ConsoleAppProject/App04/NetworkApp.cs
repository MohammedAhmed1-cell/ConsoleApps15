using System;
using ConsoleAppProject.Helpers;
namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();
        
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("     Mohammed's News Feed");

            string[] choices = new string[]
            {
                "Post Message", "Post Image",
                "DisplayMenu All Posts", "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: DisplayAll(); break;
                    case 4: wantToQuit = true; break;

                }

            } while (!wantToQuit);
          
            
            

        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void PostImage()
        {
            Console.WriteLine("Enter file name: ");
            string filename = Console.ReadLine();
            Console.WriteLine("Enter caption: ");
            string caption = Console.ReadLine();
            PhotoPost post = new PhotoPost(news.GetAuthor(), filename, caption);
            news.AddPhotoPost(post);

        }

        private void PostMessage()
        {
            Console.WriteLine("Enter your message: ");
            string message = Console.ReadLine();
            MessagePost post = new MessagePost(news.GetAuthor(), message);
            news.AddMessagePost(post);
        }
    }
}
