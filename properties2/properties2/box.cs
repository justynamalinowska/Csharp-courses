using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Properties
{
    public class Box
    {
        //member variable
        private int length;
        private int height;
        //public int width;
        private int volume;

        //public int Volume { get; set; }

        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }

        }


        public int Width { get; set; }


        //this ^ is the same


        //public int Width
        //{
        //    get
        //    {
        //        return this.width;
        //    }
        //    set
        //    {
        //        this.width = value;
        //    }
        //}





        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
        }


        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }


        public void SetLength(int length)
        {
            if(length<0)
            {
                throw new Exception("Length sholud be higher than 0");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        public int GetVolume()
        {
            return this.length * this.height * this.Width;
        }



        public void DisplayInfo()
        {
            Console.WriteLine($"Length is {length}, height is {height} and width is {Width}" +
                $" so the volume is {volume=length*height*Width}.");
        }
    }
}

