//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace EntranceExam
//{
//    class SBANKS
//    {
//        public void SortingBankAccounts()
//        {
//            int t = int.Parse(Console.ReadLine());

//            for (int p = 0; p < t; p++)
//            {

//                int n = int.Parse(Console.ReadLine());

//                Dictionary<string, int> map = new SortedDictionary<string, Integer>();

//                for (int i = 0; i < n; ++i)
//                {

//                    String s = in.readLine();

//                    if (!map.containsKey(s))

//                        map.put(s, 0);

//                    map.put(s, map.get(s) + 1);

//                }
//            }

//            Iterator it = map.entrySet().iterator();

//            while (it.hasNext())
//            {

//                Map.Entry entry = (Map.Entry)it.next();

//                out.printLine(entry.getKey(), entry.getValue());

//            }

//            out.printLine();

//        }


//    }
//        //public void SBank()
//        //{
//        //    int times = int.Parse(Console.ReadLine());
//        //    SortedDictionary<string, int> accountNumbers = new SortedDictionary<string, int>();
//        //    while (times-- > 0)
//        //    {
//        //        int numbers = int.Parse(Console.ReadLine());
//        //        for (int i = 0; i < numbers; i++)
//        //        {
//        //            var str = Console.ReadLine();
//        //            accountNumbers.Add(str, i);
//        //        }

//        //        foreach (var item in accountNumbers)
//        //        {
//        //            Console.WriteLine(item.Value + " " + item.Key);
//        //        }
//        //    }
//        //}
//        //        Map<String, Integer> mp = new HashMap<>();
//        //        TreeSet<String> st = new TreeSet<>();
//        //        int t;
//        //        Scanner s = new Scanner(System.in);
//        //        t= s.nextInt();
//        //        for(int i=0;i<t;i++)
//        //        {
//        //            mp.clear();
//        //            st.clear();
//        //            int n;
//        //            n=s.nextInt();
//        //               String s1;
//        //             s1=s.nextLine();
//        //            for(int j=0;j<n;j++)
//        //            {
//        //                s1=s.nextLine();
//        //              st.add(s1);
//        //                if(mp.get(s1)!=null)
//        //                {
//        //                    int val = mp.get(s1);
//        //                    val++; 
//        //                    mp.put(s1,val);
//        //                }
//        //                else
//        //                {
//        //                    mp.put(s1,1);
//        //                }
//        //            }
//        //            Iterator<String>itr = st.iterator();
//        //            while(itr.hasNext())
//        //            {
//        //              s1 = itr.next();
//        //                System.out.println(s1+" "+mp.get(s1));
//        //            }
//        //               System.out.println();
//        //        } 
//        // }
//        //}
//        public void SIMPLE()
//        {
//            List<string> list = new List<string>();
//            int times = int.Parse(Console.ReadLine());
//            while (times-- > 0)
//            {
//                int elements = int.Parse(Console.ReadLine());
//                for (int i = 0; i < elements; i++)
//                {
//                    list.Add(Console.ReadLine());
//                }

//                foreach (var item in list)
//                {
//                    Console.WriteLine(item);
//                }
//            }
//        }
//        public void last() { 
//        }
//        public void Convert()
//        {
//            Dictionary<string, int> mp = new Dictionary<string, int>();
//            SortedSet<string> st = new SortedSet<string>();

//            //Scanner s = new Scanner(System.in);
//            int t = int.Parse(Console.ReadLine());
//            for (int i = 0; i < t; i++)
//            {
//                mp.Clear();
//                st.Clear();
//                int n = int.Parse(Console.ReadLine());
//                var s1 = Console.ReadLine();
//                for (int j = 0; j < n; j++)
//                {
//                    s1 = Console.ReadLine();
//                    st.Add(s1);
//                    if (mp[s1] != null)
//                    {
//                        int val = mp.GetValueOrDefault(s1);
//                        val++;
//                        mp.Add(s1, val);
//                    }
//                    else
//                    {
//                        mp.Add(s1,1);
//                    }
//                }
//                IEnumerator<string> itr = st.GetEnumerator();
//                while (itr.MoveNext())
//                {
//                    s1 = itr.Current;
//                    Console.WriteLine(s1 + " " + mp[s1]);
//                }
//                Console.WriteLine();
//            }
//        }
//            //public void sortingAccounts()
//            //{
//            //    Dictionary<string, int> st = new Dictionary<string, int>();
//            //    int testcases = int.Parse(Console.ReadLine());
//            //    Console.WriteLine(testcases);
//            //    SortedDictionary<string, int> sd = new SortedDictionary<string, int>();
//            //    while (testcases-- > 0)
//            //    {
//            //        int elements = int.Parse(Console.ReadLine());
//            //        for (int i = 0; i < elements; i++)
//            //        {
//            //            st.Clear();
//            //            sd.Clear();
//            //            for (int i = 0; i < t; i++)
//            //            {
//            //                mp.clear();
//            //                st.clear();
//            //                int n;
//            //                n = s.nextInt();
//            //                String s1;
//            //                s1 = s.nextLine();
//            //                for (int j = 0; j < n; j++)
//            //                {
//            //                    s1 = s.nextLine();
//            //                    st.Add(s1, int.Parse(s1));
//            //                    if (mp.get(j, s1) != null)
//            //                    {
//            //                        int val = mp.get(s1);
//            //                        val++;
//            //                        mp.put(s1, val);
//            //                    }
//            //                    else
//            //                    {
//            //                        mp.put(s1, 1);
//            //                    }
//            //                }
//            //            }
//            //        }
//            //    }
//            //public void SBANKS()
//            //{
//            //    //  Map<String,Integer> mp = new HashMap<>();
//            //    Dictionary<string, int> mp = new Dictionary<string, int>();
//            //    // TreeSet<String> st = new TreeSet<>();
//            //    SortedList<string, int> st = new SortedList<string, int>();
//            //    int t=inte;
//            //    // Scanner s = new Scanner(System.in);
//            //    while (t-- > 0) {
//            //        t = Console.ReadLine();
//            //        for (int i = 0; i < t; i++)
//            //        {
//            //            mp.Clear();
//            //            st.Clear();
//            //            int n;
//            //            n = int.Parse(Console.ReadLine());
//            //            string s1;
//            //            s1 = Console.ReadLine();
//            //            for (int j = 0; j < n; j++)
//            //            {
//            //                s1 = Console.ReadLine();
//            //                st.Add(s1);
//            //                if (mp[s1] != null)
//            //                {
//            //                    int val = mp[s1];
//            //                    val++;
//            //                    //mp.put(s1, val);
//            //                    mp[s1]= mp[val].ToString();
//            //                }
//            //                else
//            //                {
//            //                    mp.put(s1, 1);
//            //                }
//            //            }
//            //            Iterator<String> itr = st.iterator();
//            //            while (itr.hasNext())
//            //            {
//            //                s1 = itr.next();
//            //                System.out.println(s1 + " " + mp.get(s1));
//            //            }
//            //            //System.out.println();
//            //            Console.WriteLine();
//            //        }
//            //    }
//            //}
//        }
//    }

//using System;

//public class Test
//{
//    public static void Main()
//    {

//        var s = Console.ReadLine();

//        int nCases = int.Parse(s);

//        while (nCases-- > 0)
//        {

//            String[] table = new String[101];
//            int count = 0;
//            int nOperations = int.Parse(Console.ReadLine());

//            while (nOperations-- > 0)
//            {

//                String op = Console.ReadLine();
//                String val = op.Substring(4);
//                int hash = Hash(val);

//                if (op[0] == 'A')
//                {

//                    bool duplicate = false;

//                    for (int i = 0; i < table.Length; i++)
//                        if (table[i] != null && table[i].Equals(val))
//                        {
//                            duplicate = true;
//                        }

//                    if (duplicate)
//                        continue;

//                    int tries = 0;
//                    while (tries < 20)
//                    {
//                        int newHash = (int)(hash + Math.Pow(tries, 2) + 23 * tries) % 101;
//                        if (table[newHash] == null || table[newHash].Equals(val))
//                        {

//                            if (table[newHash] == null)
//                                count++;

//                            table[newHash] = val;
//                            break;
//                        }
//                        tries++;
//                    }

//                }
//                else
//                {

//                    int tries = 0;
//                    while (tries < 20)
//                    {
//                        int newHash = (int)(hash + Math.Pow(tries, 2) + 23 * tries) % 101;
//                        if (table[newHash] != null && table[newHash].Equals(val))
//                        {
//                            count--;
//                            table[newHash] = null;
//                            break;
//                        }
//                        tries++;
//                    }
//                }
//            }
//            Console.WriteLine(count);


//            for (int i = 0; i < table.Length; i++)
//                if (table[i] != null)
//                    Console.WriteLine(i + ":" + table[i]);

//        }
//    }
//    public static int Hash(String key)
//    {
//        return h(key) % 101;
//    }

//    public static int h(String key)
//    {
//        int h = 0;

//        for (int i = 0; i < key.Length; i++)
//            h += key[i] * (i + 1);

//        return 19 * h;
//    }
//}
