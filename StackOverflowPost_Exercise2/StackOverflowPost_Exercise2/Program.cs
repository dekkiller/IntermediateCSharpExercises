using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost_Exercise2
{

    class Post
    {
        public Post()
        {
            CreationTime = DateTime.Now;
            VoteValue = 0;
        }

        public Post(string title, string description)
            :this()
        {
            this.Title = title;
            this.Description = description;
        }
        
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; }
        public int VoteValue { get; private set; }

        public void Upvote()
        {
            VoteValue += 1;
        }

        public void Downvote()
        {
            VoteValue -= 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Post();
            test.Title = "hello";
            test.Upvote();
            test.Upvote();
            Console.WriteLine(test.Title + test.Description + test.VoteValue);
            test.Downvote();
            Console.WriteLine(test.Title + test.Description + test.VoteValue);
            var test2 = new Post("IS this okay", "but really is it");
            Console.WriteLine(test2.Title + test2.Description + test2.VoteValue);

        }
    }
}
