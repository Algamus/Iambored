using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Am_Bored
{
    public class IAMBORED
    {
        private int padding = 7;
        private int writingspeed = 125;
        private string iamboredstr = "I Am Bored";

        public IAMBORED()
        {

        }

        public void playIntro()
        {
            //
            //I am bored.Do you want to see how much I have been?
            //Do you want to see how much I have been?
            Console.WriteLine("");
            addpadding(" ", padding, 0);
            addpadding(". ", 10,250);
            Console.WriteLine("");


            writestrwithanimation("Hello World.");
            writestrwithanimation("I Am Bored.");
            writestrwithanimation("Do You Want To See How Much I Have Been BboOorRreEedD?");

            addpadding(" ", padding, 0);
            Console.WriteLine("(To See Press Enter Key.)");
            Console.ReadLine();

            Console.Clear();
            //Console.Write("Hello World.");

        }

        

        private void writestrwithanimation(string s)
        {
            addpadding(" ", padding, 0);
            foreach (char c in s)
            {
                addpadding(c.ToString(), 1, writingspeed);
            }
            Console.WriteLine("");
        }

        private void addpadding(string s,int c,int sleeptime)
        {
            for (int i = 0; i < c; i++)
            {
                Console.Write(s);
                System.Threading.Thread.Sleep(sleeptime);
            }
        }

        public void playShow()
        {
            while (true) {
                writeStringtriangle(10, iamboredstr);
                reversewriteStringtriangle(10, iamboredstr);
                writeStringtriangleToEnd(10, iamboredstr);
                reversewriteStringtriangleToEnd(10, iamboredstr);
                pullingstring(10, iamboredstr);

                writeStringAccordioan(10, iamboredstr, 3);
                leftwriteStringAccordioan(10, iamboredstr, 3);
                rightwriteStringAccordioan(10, iamboredstr, 3);
                writeStringAccordioan(10, iamboredstr, 1);
                leftwriteStringAccordioan(10, iamboredstr, 1);
                rightwriteStringAccordioan(10, iamboredstr, 1);
                writeStringAccordioan(10, iamboredstr, 1);
                pushingstring(10, iamboredstr);

                bigsmallshow(iamboredstr, 10);

                string s = pullingstringwithouthook(10, iamboredstr);
                bigsmallshow(s, 10);
                pushingstringwithouthook(10, iamboredstr);
                writeStringtriangle(10, iamboredstr);
                reversewriteStringtriangle(10, iamboredstr);

                writeStringAccordioan(10, iamboredstr, 1);
                bigsmallshow(s, 10);
                leftwriteStringAccordioan(10, iamboredstr, 1);
                rightwriteStringAccordioan(10, iamboredstr, 1);
                writeStringAccordioan(10, iamboredstr, 1);
                pushingstring(10, iamboredstr);

                bigsmallshow(iamboredstr, 10);
                writeStringtriangleToEnd(10, iamboredstr);
                reversewriteStringtriangleToEnd(10, iamboredstr);
                bigsmallshow(iamboredstr, 10);

                pullingstringwithouthook(10, iamboredstr);
                pushingstringwithouthook(10, iamboredstr);

            }
            
            
        }

        private void writeStringtriangle(int addXspace,string str)
        {
            for (int i = 0; i < addXspace; i++)
            {
                addpadding(" ", padding, 0);
                addpadding(" ", i + 1, 0);
                addpadding(str, 1, 0);
                Console.WriteLine();
                System.Threading.Thread.Sleep(writingspeed);
            }
        }
        private void reversewriteStringtriangle(int addXspace, string str)
        {
            for (int i = 0; i < addXspace; i++)
            {
                addpadding(" ", padding, 0);
                addpadding(" ", addXspace-i, 0);
                addpadding(str, 1, 0);
                Console.WriteLine();
                System.Threading.Thread.Sleep(writingspeed);
            }
        }

        private void writeStringtriangleToEnd(int addXspace, string str)
        {
            int strcount = str.Length;
            int i = 0;
            for (int k = strcount; k > 0; k--)
            {
                addpadding(" ", padding, 0);
                Console.Write(str.Substring(0, strcount - i));
                addpadding(" ", addXspace, 0);
                Console.Write(str.Substring(k, strcount - k));
                Console.WriteLine();
                System.Threading.Thread.Sleep(writingspeed);
                i++;
            }

        }
        private void reversewriteStringtriangleToEnd(int addXspace, string str)
        {
            int strcount = str.Length;
            int i = strcount;
            for (int k = 0; k < strcount; k++)
            {
                addpadding(" ", padding, 0);
                Console.Write(str.Substring(0, strcount - i));
                addpadding(" ", addXspace, 0);
                Console.Write(str.Substring(k, strcount - k));
                Console.WriteLine();
                System.Threading.Thread.Sleep(writingspeed);
                i--;
            }


        }
        private string getpullingvers(int addXspace, string str)
        {
            int strcount = str.Length;

            string line = str;
            List<string> acordlist = new List<string>();
            acordlist.Add(line);


            //phase1 pump up
            for (int i1 = 0; i1 < addXspace; i1++)
            {
                //addpadding(" ", padding, 0);
                //Console.Write(str);
                line = str;
                //addpadding(" ", addXspace - i1 - 1, 0);
                for (int z = 0; z < addXspace - i1 - 1; z++)
                {
                    line += " ";
                }
                //Console.Write("|");
                line += "|";
                for (int i2 = i1; i2 > 0; i2--)
                {
                    //Console.Write("-");
                    line += "-";
                }
                acordlist.Add(line);
                //Console.WriteLine();
                //System.Threading.Thread.Sleep(writingspeed);
            }
            int b = 0;
            int strtempcount = 1;
            string strtemp = str;
            for (int i3 = addXspace; i3 > 0; i3--)
            {
                //addpadding(" ", padding, 0);
                string sxbas = strtemp.Substring(0, strtempcount);

                int a = strtemp.Length - sxbas.Length;

                string sxson = strtemp.Substring(b + 1, a);
                strtemp = sxbas + " " + sxson;
                //Console.Write(strtemp);
                line = strtemp;
                b += 2;
                strtempcount++;
                strtempcount++;
                if (i3 - 1 > 0)
                {
                    //Console.Write("|");
                    line += "|";
                }

                for (int i4 = i3 - 2; i4 > 0; i4--)
                {
                    //Console.Write("-");
                    line += "-";
                }

                acordlist.Add(line);
                //Console.WriteLine();
                //System.Threading.Thread.Sleep(writingspeed);
            }
           
            return strtemp;
        }
        private string pullingstring(int addXspace,string str)
        {
            int strcount = str.Length;

            string line = str;
            List<string> acordlist = new List<string>();
            acordlist.Add(line);
            

            //phase1 pump up
            for (int i1 = 0; i1 < addXspace; i1++)
            {
                //addpadding(" ", padding, 0);
                //Console.Write(str);
                line = str;
                //addpadding(" ", addXspace - i1 - 1, 0);
                for(int z=0;z< addXspace - i1 - 1; z++)
                {
                    line += " ";
                }
                //Console.Write("|");
                line += "|";
                for (int i2 = i1; i2 > 0; i2--)
                {
                    //Console.Write("-");
                    line += "-";
                }
                acordlist.Add(line);
                //Console.WriteLine();
                //System.Threading.Thread.Sleep(writingspeed);
            }
            int b = 0;
            int strtempcount = 1;
            string strtemp = str;
            for (int i3 = addXspace; i3 > 0; i3--)
            {
                //addpadding(" ", padding, 0);
                string sxbas = strtemp.Substring(0, strtempcount);

                int a = strtemp.Length - sxbas.Length;

                string sxson = strtemp.Substring(b + 1, a);
                strtemp = sxbas + " " + sxson;
                //Console.Write(strtemp);
                line = strtemp;
                b += 2;
                strtempcount++;
                strtempcount++;
                if (i3 - 1 > 0) {
                    //Console.Write("|");
                    line += "|";
                }

                for (int i4 = i3 - 2; i4 > 0; i4--)
                {
                    //Console.Write("-");
                    line += "-";
                }
                
                acordlist.Add(line);
                //Console.WriteLine();
                //System.Threading.Thread.Sleep(writingspeed);
            }
            for (int lcount = 0; lcount < acordlist.Count; lcount++)
            {

                addpadding(" ", padding, 0);
                
                line = acordlist[lcount];
                Console.Write(line);
                Console.WriteLine();
                System.Threading.Thread.Sleep(writingspeed);

            }
            return strtemp;
        }
        private string pushingstring(int addXspace, string str)
        {
            int strcount = str.Length;

            string line = str;
            List<string> acordlist = new List<string>();
            acordlist.Add(line);


            //phase1 pump up
            for (int i1 = 0; i1 < addXspace; i1++)
            {
                //addpadding(" ", padding, 0);
                //Console.Write(str);
                line = str;
                //addpadding(" ", addXspace - i1 - 1, 0);
                for (int z = 0; z < addXspace - i1 - 1; z++)
                {
                    line += " ";
                }
                //Console.Write("|");
                line += "|";
                for (int i2 = i1; i2 > 0; i2--)
                {
                    //Console.Write("-");
                    line += "-";
                }
                acordlist.Add(line);
                //Console.WriteLine();
                //System.Threading.Thread.Sleep(writingspeed);
            }
            int b = 0;
            int strtempcount = 1;
            string strtemp = str;
            for (int i3 = addXspace; i3 > 0; i3--)
            {
                //addpadding(" ", padding, 0);
                string sxbas = strtemp.Substring(0, strtempcount);

                int a = strtemp.Length - sxbas.Length;

                string sxson = strtemp.Substring(b + 1, a);
                strtemp = sxbas + " " + sxson;
                //Console.Write(strtemp);
                line = strtemp;
                b += 2;
                strtempcount++;
                strtempcount++;
                if (i3 - 1 > 0)
                {
                    //Console.Write("|");
                    line += "|";
                }

                for (int i4 = i3 - 2; i4 > 0; i4--)
                {
                    //Console.Write("-");
                    line += "-";
                }

                acordlist.Add(line);
                //Console.WriteLine();
                //System.Threading.Thread.Sleep(writingspeed);
            }
            for (int lcount = acordlist.Count - 1; lcount >= 0; lcount--)
            {

                addpadding(" ", padding, 0);
  
                line = acordlist[lcount];
                Console.Write(line);
                Console.WriteLine();
                System.Threading.Thread.Sleep(writingspeed);

            }
            return strtemp;
        }
        private void writeStringAccordioan(int addXspace,string str,int times)
        {
            string strg = getpullingvers(addXspace,str);
            int counter = 0;
            int extarnalspacecount = 0;
            strg = cutendofspace(strg);

            List<string> acordlist = new List<string>();
            acordlist.Add(strg);
            List<int> acordlistextarnalspacecount = new List<int>();
            acordlistextarnalspacecount.Add(extarnalspacecount);

            bool listisdone = false;
            while (!listisdone)
            {
                int ibas = findstrfirstspaceindex(strg);
                int ison = findstrlastspaceindex(strg);
                if (ibas == 0 & ison == 0)
                {
                    listisdone = true;
                    continue;
                }
                if (ibas == ison)
                {
                    string begin = strg.Substring(0, ibas);
                    string end = strg.Substring(ison + 1, strg.Length - ison - 1);
                    strg = begin + end;
                    acordlist.Add(strg);
                    extarnalspacecount++;
                    acordlistextarnalspacecount.Add(extarnalspacecount);
                }
                else
                {
                    
                    
                        string begin = strg.Substring(0, ibas);
                        string mid = strg.Substring(ibas + 1, ison - ibas-1);
                        string end = strg.Substring(ison + 1, strg.Length - ison - 1);
                        strg = begin + mid + end;
                        acordlist.Add(strg);
                    extarnalspacecount += 2;
                    acordlistextarnalspacecount.Add(extarnalspacecount);



                }
            }

          
            
            do
            {
                for(int lcount = 0; lcount < acordlist.Count; lcount++)
                {

                    addpadding(" ", padding, 0);
                    addpadding(" ", acordlistextarnalspacecount[lcount]/2, 0);
                    strg = acordlist[lcount];
                    Console.Write(strg);
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(writingspeed);

                }
                for (int lcount = acordlist.Count-1; lcount >=0; lcount--)
                {

                    addpadding(" ", padding, 0);
                    addpadding(" ", acordlistextarnalspacecount[lcount]/2, 0);
                    strg = acordlist[lcount];
                    Console.Write(strg);
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(writingspeed);

                }

                counter++;
            } while (counter<times);
            //phase3 norm
           
        }
        private void leftwriteStringAccordioan(int addXspace, string str, int times)
        {
            string strg = getpullingvers(addXspace, str);
            int counter = 0;
            int extarnalspacecount = 0;
            strg = cutendofspace(strg);

            List<string> acordlist = new List<string>();
            acordlist.Add(strg);
            List<int> acordlistextarnalspacecount = new List<int>();
            acordlistextarnalspacecount.Add(extarnalspacecount);

            bool listisdone = false;
            while (!listisdone)
            {
                int ibas = findstrfirstspaceindex(strg);
                int ison = findstrlastspaceindex(strg);
                if (ibas == 0 & ison == 0)
                {
                    listisdone = true;
                    continue;
                }
                if (ibas == ison)
                {
                    string begin = strg.Substring(0, ibas);
                    string end = strg.Substring(ison + 1, strg.Length - ison - 1);
                    strg = begin + end;
                    acordlist.Add(strg);
                    extarnalspacecount++;
                    acordlistextarnalspacecount.Add(extarnalspacecount);
                }
                else
                {


                    string begin = strg.Substring(0, ibas);
                    string mid = strg.Substring(ibas + 1, ison - ibas - 1);
                    string end = strg.Substring(ison + 1, strg.Length - ison - 1);
                    strg = begin + mid + end;
                    acordlist.Add(strg);
                    extarnalspacecount += 2;
                    acordlistextarnalspacecount.Add(extarnalspacecount);



                }
            }



            do
            {
                for (int lcount = 0; lcount < acordlist.Count; lcount++)
                {

                    addpadding(" ", padding, 0);
                    
                    strg = acordlist[lcount];
                    Console.Write(strg);
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(writingspeed);

                }
                for (int lcount = acordlist.Count - 1; lcount >= 0; lcount--)
                {

                    addpadding(" ", padding, 0);
                   
                    strg = acordlist[lcount];
                    Console.Write(strg);
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(writingspeed);

                }

                counter++;
            } while (counter < times);
            //phase3 norm

        }
        private void rightwriteStringAccordioan(int addXspace, string str, int times)
        {
            string strg = getpullingvers(addXspace, str);
            int counter = 0;
            int extarnalspacecount = 0;
            strg = cutendofspace(strg);

            List<string> acordlist = new List<string>();
            acordlist.Add(strg);
            List<int> acordlistextarnalspacecount = new List<int>();
            acordlistextarnalspacecount.Add(extarnalspacecount);

            bool listisdone = false;
            while (!listisdone)
            {
                int ibas = findstrfirstspaceindex(strg);
                int ison = findstrlastspaceindex(strg);
                if (ibas == 0 & ison == 0)
                {
                    listisdone = true;
                    continue;
                }
                if (ibas == ison)
                {
                    string begin = strg.Substring(0, ibas);
                    string end = strg.Substring(ison + 1, strg.Length - ison - 1);
                    strg = begin + end;
                    acordlist.Add(strg);
                    extarnalspacecount++;
                    acordlistextarnalspacecount.Add(extarnalspacecount);
                }
                else
                {


                    string begin = strg.Substring(0, ibas);
                    string mid = strg.Substring(ibas + 1, ison - ibas - 1);
                    string end = strg.Substring(ison + 1, strg.Length - ison - 1);
                    strg = begin + mid + end;
                    acordlist.Add(strg);
                    extarnalspacecount += 2;
                    acordlistextarnalspacecount.Add(extarnalspacecount);



                }
            }



            do
            {
                for (int lcount = 0; lcount < acordlist.Count; lcount++)
                {

                    addpadding(" ", padding, 0);
                    addpadding(" ", acordlistextarnalspacecount[lcount], 0);
                    strg = acordlist[lcount];
                    Console.Write(strg);
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(writingspeed);

                }
                for (int lcount = acordlist.Count - 1; lcount >= 0; lcount--)
                {

                    addpadding(" ", padding, 0);
                    addpadding(" ", acordlistextarnalspacecount[lcount], 0);
                    strg = acordlist[lcount];
                    Console.Write(strg);
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(writingspeed);

                }

                counter++;
            } while (counter < times);
            //phase3 norm

        }
        private int findstrfirstspaceindex(string s)
        {
            int count = 0;
            int index = count;
            foreach (char c in s)
            {
                if(c.Equals(' '))
                {
                    index = count;
                    break;
                }
                count++;
            }
            return index;
        }
        private int findstrlastspaceindex(string s)
        {
            int count = 0;
            int index = count;
            foreach (char c in s)
            {
                if (c.Equals(' '))
                {
                    if (s.Length!=count+1)
                    {
                        index = count;
                    }
                    
                }
                count++;
            }
            return index;
        }

        private string cutendofspace(string s) {
            string newform = s;
            if (s.Substring(s.Length - 1, 1).Equals(" ")) { 
                newform = cutendofspace(s.Substring(0, s.Length - 1)); 
                
            }
            return newform;
        }


        private string pullingstringwithouthook(int addXspace, string str)
        {
            int strcount = str.Length;

            string line = str;
            List<string> acordlist = new List<string>();
            acordlist.Add(line);


            //phase1 pump up
            for (int i1 = 0; i1 < addXspace; i1++)
            {
                //addpadding(" ", padding, 0);
                //Console.Write(str);
                line = str;
                //addpadding(" ", addXspace - i1 - 1, 0);
                for (int z = 0; z < addXspace - i1 - 1; z++)
                {
                    line += " ";
                }
                //Console.Write("|");
                
                acordlist.Add(line);
                //Console.WriteLine();
                //System.Threading.Thread.Sleep(writingspeed);
            }
            int b = 0;
            int strtempcount = 1;
            string strtemp = str;
            for (int i3 = addXspace; i3 > 0; i3--)
            {
                //addpadding(" ", padding, 0);
                string sxbas = strtemp.Substring(0, strtempcount);

                int a = strtemp.Length - sxbas.Length;

                string sxson = strtemp.Substring(b + 1, a);
                strtemp = sxbas + " " + sxson;
                //Console.Write(strtemp);
                line = strtemp;
                b += 2;
                strtempcount++;
                strtempcount++;
                

                acordlist.Add(line);
                //Console.WriteLine();
                //System.Threading.Thread.Sleep(writingspeed);
            }
            for (int lcount = 0; lcount < acordlist.Count; lcount++)
            {

                addpadding(" ", padding, 0);

                line = acordlist[lcount];
                Console.Write(line);
                Console.WriteLine();
                System.Threading.Thread.Sleep(writingspeed);

            }
            return strtemp;
        }
        private string pushingstringwithouthook(int addXspace, string str)
        {
            int strcount = str.Length;

            string line = str;
            List<string> acordlist = new List<string>();
            acordlist.Add(line);


            //phase1 pump up
            for (int i1 = 0; i1 < addXspace; i1++)
            {
                //addpadding(" ", padding, 0);
                //Console.Write(str);
                line = str;
                //addpadding(" ", addXspace - i1 - 1, 0);
                for (int z = 0; z < addXspace - i1 - 1; z++)
                {
                    line += " ";
                }
                
                acordlist.Add(line);
                //Console.WriteLine();
                //System.Threading.Thread.Sleep(writingspeed);
            }
            int b = 0;
            int strtempcount = 1;
            string strtemp = str;
            for (int i3 = addXspace; i3 > 0; i3--)
            {
                //addpadding(" ", padding, 0);
                string sxbas = strtemp.Substring(0, strtempcount);

                int a = strtemp.Length - sxbas.Length;

                string sxson = strtemp.Substring(b + 1, a);
                strtemp = sxbas + " " + sxson;
                //Console.Write(strtemp);
                line = strtemp;
                b += 2;
                strtempcount++;
                strtempcount++;
                

                acordlist.Add(line);
                //Console.WriteLine();
                //System.Threading.Thread.Sleep(writingspeed);
            }
            for (int lcount = acordlist.Count - 1; lcount >= 0; lcount--)
            {

                addpadding(" ", padding, 0);

                line = acordlist[lcount];
                Console.Write(line);
                Console.WriteLine();
                System.Threading.Thread.Sleep(writingspeed);

            }
            return strtemp;
        }

        private void bigsmallshow(string str,int times)
        {
            int counter = 0;
            bool isbig = false;
            
            do
            {
                if (counter%2==0)
                {
                    isbig = true;
                }
                else
                {
                    isbig = false;
                }
                addpadding(" ", padding, 0);
                foreach (char c in str)
                {
                    if(c.Equals(' '))
                    {
                        Console.Write(c.ToString());
                    }
                    else
                    {
                        if (isbig)
                        {
                            Console.Write(c.ToString().ToUpper().ToString());
                            isbig = false;
                        }
                        else
                        {
                            Console.Write(c.ToString().ToLower().ToString());
                            isbig = true;
                        }
                    }
                    
                }
                Console.WriteLine();
                System.Threading.Thread.Sleep(writingspeed);
                counter++;
            } while (counter < times);

        }
    }
}
