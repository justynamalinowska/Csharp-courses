using System;
using System.Threading.Tasks;

namespace Inheritance2
{
	public class VideoPost : Post
	{
        //member fields
        protected bool IsPlaying = false;
        protected int CurrDuration = 0;
        Timer timer;

        //properities
		protected string VideoURL { get; set; }
		protected int Length { get; set; }



		public VideoPost()
		{
		}

        public VideoPost(string title, bool ispublic, string videoURL, int length, string sendby)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendBy = sendby;
            this.IsPublic = ispublic;

            this.VideoURL = videoURL;
            this.Length = length;

        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.SendBy} - {this.VideoURL} - {this.Length}");
        }

        public void Play()
        {
            if (!IsPlaying)
            {
                IsPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallBack, null, 0, 1000);
            }
            
        }

        private void TimerCallBack(object o)
        {
            if (CurrDuration < Length)
            {
                CurrDuration++;
                Console.WriteLine($"Video at {CurrDuration}s");
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (IsPlaying)
            {
                IsPlaying = false;
                Console.WriteLine($"Stoped at {CurrDuration}");
            }
        }
    }
}

