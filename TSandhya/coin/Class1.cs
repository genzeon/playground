using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coin
{
    
    public enum flips
    {
        Heads , Tails
    }
   
    public class Class1
    {
        
        flips turn1;
        flips turn2;
        public int headcount;
        public int tailcount;
        //public int _Headcount
        //{
        //    get { return headcount; }
        //    set { headcount = value; }  
        //}
        //public int _Tailcount
        //{
        //    get { return tailcount; }
        //    set { tailcount = value; }  
            
        //}
        public void set_init()
        {
            Up=flips.Heads;
            Down=flips.Tails;
        }
        public flips Up 
        {

            get
            {
                return turn1;
            }
            set
            {
               turn1=value;
            }
        }
        public flips Down
        {

            get
            {
                return turn2;
            }
            set
            {
               turn2=value;
            }
        }
      
        public Class1()
        {
            Up = flips.Heads;
            Down= flips.Tails;
            
        }

        public void flip()
        {

            Random random = new Random();
            int num = random.Next(2);
            if (num == 0)
            {
               
                {
                    Up = flips.Heads;
                    Down = flips.Tails;

                };
            }
            else
            {
                Up = flips.Tails;
                Down = flips.Heads ;

            }
        }
        public void count()
        {
            
            if (Up == flips.Heads)
            {
                headcount++;
            }
            else
            {
                tailcount++;
            }
        }
        
      
        public override string ToString()
        {
            string str;
            str = $"up={Up} , down= {Down}";
           
       
            return str;
        }
           
        static void Main(string[] args)
        {
          
            Class1 con=new Class1();
          
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(con.ToString());
              
            }
          
            Console.ReadLine();
           
        }
    }
}
