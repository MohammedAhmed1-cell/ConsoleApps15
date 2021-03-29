using System;
using ConsoleAppProject.Helpers;
namespace ConsoleAppProject.App04
{
    /// <summary>
    /// This is my network app class which is the display menu of when i start the application
    /// </summary>
    public class NetworkApp
    {
        /// <summary>
        /// Directed to the news feed class
        /// </summary>
        private NewsFeed news = new NewsFeed();

        /// <summary>
        /// How many posts i have inserted
        /// </summary>
        private int PostCount = 2;

        /// <summary>
        /// This is the display menu method of what will appear on screen
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("     Mohammed's News Feed");

            // a variable/method for real dates and times
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToLongDateString());
            Console.WriteLine(dateTime.ToLongTimeString());

            // all the avaliable choices for the menu
            string[] choices = new string[]
            {
                "Post Message", "Post Image",
                "DisplayMenu All Posts","Delete Message","Like/Unlike","Add Comment", "Quit"
            };

            //this is a do loop which gives the cases of all the choices for when starting the app
            bool wantToQuit = false;
            do
            {
                // by using the console helper i can choose any of the cases in any order
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: DisplayAll(); break;
                    case 4: DeleteMessage(); break;
                    case 5: LikePost(); break;
                    case 6: AddComment(); break;
                    case 7: wantToQuit = true; break;


                }

            } while (!wantToQuit);
          
            
            

        }

        /// <summary>
        /// For each option i had to create a private void for each of them in order for them to work.
        /// This one is to display all messages.
        /// </summary>
        private void DisplayAll()
        {
            news.Display();
        }

        /// <summary>
        /// To post an image with the file name and said caption
        /// </summary>
        private void PostImage()
        {
            Console.WriteLine("Enter file name: ");
            string filename = Console.ReadLine();
            Console.WriteLine("Enter caption: ");
            string caption = Console.ReadLine();
            PhotoPost post = new PhotoPost(news.GetAuthor(), filename, caption, PostCount);
            news.AddPhotoPost(post);

        }

        /// <summary>
        /// This one is to post a message
        /// </summary>
        private void PostMessage()
        {
            Console.WriteLine("Enter your message: ");
            PostCount++;
            string message = Console.ReadLine();
            MessagePost post = new MessagePost(news.GetAuthor(), message, PostCount);
            news.AddMessagePost(post);
        }

        /// <summary>
        /// This one is to delete a messsage
        /// </summary>
        private void DeleteMessage()
        {
            Console.WriteLine("Please enter the id of the post you want to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            news.RemovePost(id);
        }

        /// <summary>
        /// This is to like and unlike a post
        /// </summary>
        private void LikePost()
        {
            ConsoleHelper.OutputTitle("Like/Unlike post");
            int id = (int)ConsoleHelper.InputNumber("Please enter the id of the post: ");

            Console.Write("Do you like this post yes/no: ");
            string awnser = Console.ReadLine();
            if(awnser.StartsWith("y"))
            {
                Post post = news.FindPost(id);
                post.Like();
            }
            else
            {
                Post post = news.FindPost(id);
                post.Unlike();
            }
        }

        /// <summary>
        /// to add said comment onto anypost
        /// </summary>
        private void AddComment()
        {
            ConsoleHelper.OutputTitle("Add a comment");
            int id = (int)ConsoleHelper.InputNumber("Now can you enter the id of post you want to comment on: ");
            Console.WriteLine("Please enter your comment: ");
            string comment = Console.ReadLine();
            Post post = news.FindPost(id);
            post.AddComment(comment);
        }
    }
}
