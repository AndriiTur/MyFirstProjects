using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;
using System.Collections.ObjectModel;

namespace MyFirtProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TestIndexOfOne(string subStr, string str)
        {
            if (MyString.IndexOf(subStr, str) != str.IndexOf(subStr))
                MessageBox.Show(
                    String.Format("MyStrings.IndexOf bad result. str '{0}', subStr '{1}', " +
                    "my result '{2}', good result '{3}'",
                    str, subStr, MyString.IndexOf(subStr, str), str.IndexOf(subStr))
               );
        }

        private void TestIndexOf()
        {
            this.TestIndexOfOne("hello", "phrase hell");
            this.TestIndexOfOne("hello", "hello phrase");
            this.TestIndexOfOne("hello", " phrase");
            this.TestIndexOfOne("hello", "hell phrase");
            this.TestIndexOfOne("hello", "hello phrase");
            this.TestIndexOfOne("hello", "phrase hello");
            this.TestIndexOfOne("hello", "phrase hhello");
            this.TestIndexOfOne("hello", "hello ");
            this.TestIndexOfOne("hello", "hhello");
            this.TestIndexOfOne("hello", "phrase hhello phrase");
            this.TestIndexOfOne("hello", "");
            this.TestIndexOfOne("", "hello phrase");
            this.TestIndexOfOne("", "");
        }

        private void TestIndexOfButton_Click(object sender, EventArgs e)
        {
            this.TestIndexOf();
        }

        private void TestStartsWithOne(string subStr, string str)
        {
            if (MyString.StartsWith(subStr, str) != str.StartsWith(subStr))
                MessageBox.Show(
                    String.Format("MyStrings.StartsWith bad result. str '{0}', subStr '{1}', " +
                    "my result '{2}', good result '{3}'",
                    str, subStr, MyString.StartsWith(subStr, str), str.StartsWith(subStr))
               );
        }

        private void TestStartsWith()
        {

            this.TestStartsWithOne("hello", "hello phrase");
            this.TestStartsWithOne("hello", " phrase");
            this.TestStartsWithOne("hello", "hell phrase");
            this.TestStartsWithOne("hello", "hello phrase");
            this.TestStartsWithOne("hello", "phrase hello");
            this.TestStartsWithOne("hello", "phrase hell");
            this.TestStartsWithOne("hello", "phrase hhello");
            this.TestStartsWithOne("hello", "hello");
            this.TestStartsWithOne("hello", "hhello");
            this.TestStartsWithOne("hello", "phrase hhello phrase");
            this.TestStartsWithOne("hello", "");
            this.TestStartsWithOne("", "hello phrase");
            this.TestStartsWithOne("", "");
        }

        private void TestStartsWithButton_Click(object sender, EventArgs e)
        {
            this.TestStartsWith();
        }

        private void TestEndsWithOne(string subStr, string str)
        {
            if (MyString.EndsWith(subStr, str) != str.EndsWith(subStr))
                MessageBox.Show(
                    String.Format("MyStrings.EndsWith bad result. str '{0}', subStr '{1}', " +
                    "my result '{2}', good result '{3}'",
                    str, subStr, MyString.EndsWith(subStr, str), str.EndsWith(subStr))
               );
        }

        private void TestEndsWith()
        {
            this.TestEndsWithOne("hello", "hello phrase");
            this.TestEndsWithOne("hello", " phrase");
            this.TestEndsWithOne("hello", "hello phrase");
            this.TestEndsWithOne("hello", "phrase hell");
            this.TestEndsWithOne("hello", "phrase hhello");
            this.TestEndsWithOne("hello", "hello");
            this.TestEndsWithOne("hello", "hhello");
            this.TestEndsWithOne("hello", "phrase hhello phrase");
            this.TestEndsWithOne("hello", "");
            this.TestEndsWithOne("", "hello phrase");
            this.TestEndsWithOne("", "");
        }

        private void TestEndsWithButton_Click(object sender, EventArgs e)
        {
            this.TestEndsWith();
        }

        private void TestLastIndexOfOne(string subStr, string str)
        {
            if (MyString.LastIndexOf(subStr, str) != str.LastIndexOf(subStr))
                MessageBox.Show(
                    String.Format("MyStrings.LastIndexOf bad result. str '{0}', subStr '{1}', " +
                    "my result '{2}', good result '{3}'",
                    str, subStr, MyString.LastIndexOf(subStr, str), str.LastIndexOf(subStr))
               );
        }

        private void TestLastIndexOf()
        {
            this.TestLastIndexOfOne("hello", "phrase hell");
            this.TestLastIndexOfOne("hello", "hello phrase");
            this.TestLastIndexOfOne("hello", " phrase");
            this.TestLastIndexOfOne("hello", "hell phrase");
            this.TestLastIndexOfOne("hello", "hello phrase");
            this.TestLastIndexOfOne("hello", "phrase hello");
            this.TestLastIndexOfOne("hello", "phrase hhello");
            this.TestLastIndexOfOne("hello", "hello ");
            this.TestLastIndexOfOne("hello", "hhello");
            this.TestLastIndexOfOne("hello", "phrase hhello phrase");
            this.TestLastIndexOfOne("hello", "");
            this.TestLastIndexOfOne("", "hello phrase");
            this.TestLastIndexOfOne("", "");
        }

        private void TestLastIndexOfButton_Click(object sender, EventArgs e)
        {
            this.TestLastIndexOf();
        }

        private void TestIndexOf2One(string subStr, string str, int startIndex)
        {
            if (MyString.IndexOf(subStr, str, startIndex) != str.IndexOf(subStr, startIndex))
                MessageBox.Show(
                    String.Format("MyStrings.IndexOf bad result. str '{0}', subStr '{1}', " +
                    "my result '{2}', good result '{3}', val '{4}'",
                    str, subStr, MyString.IndexOf(subStr, str, startIndex), str.IndexOf(subStr, startIndex), startIndex)
               );
        }

        private void TestIndexOf2()
        {
            this.TestIndexOf2One("hello", "phrase hell", 2);
            this.TestIndexOf2One("hello", "hello phrase", 3);
            this.TestIndexOf2One("hello", " phrase", 4);
            this.TestIndexOf2One("hello", "hell phrase", 4);
            this.TestIndexOf2One("hello", "phrase hello", 2);
            this.TestIndexOf2One("hello", "phrase hhello", 5);
            this.TestIndexOf2One("hello", "hello ", 3);
            this.TestIndexOf2One("hello", "hhello", 4);
            this.TestIndexOf2One("hello", "phrase hhello phrase", 3);
            this.TestIndexOf2One("", "hello phrase", 3);
            this.TestIndexOf2One("", "", 0);
            this.TestIndexOf2One("hello", "", 0);
        }

        private void TestIndexOfButton2_Click(object sender, EventArgs e)
        {
            this.TestIndexOf2();
        }

        private void TestLastIndexOf2One(string subStr, string str, int startIndex)
        {
            if (MyString.LastIndexOf(subStr, str, startIndex) != str.LastIndexOf(subStr, startIndex))
                MessageBox.Show(
                    String.Format("MyStrings.IndexOf bad result. str '{0}', subStr '{1}', " +
                    "my result '{2}', good result '{3}', val '{4}'",
                    str, subStr, MyString.LastIndexOf(subStr, str, startIndex), str.LastIndexOf(subStr, startIndex), startIndex)
               );
        }

        private void TestLastIndexOf2()
        {
            this.TestLastIndexOf2One("hello", "phrase hell", 2);
            this.TestLastIndexOf2One("hello", "hello phrase", 3);
            this.TestLastIndexOf2One("hello", " phrase", 4);
            this.TestLastIndexOf2One("hello", "hell phrase", 4);
            this.TestLastIndexOf2One("hello", "phrase hello", 2);
            this.TestLastIndexOf2One("hello", "phrase hhello", 5);
            this.TestLastIndexOf2One("hello", "hello ", 3);
            this.TestLastIndexOf2One("hello", "hhello", 4);
            this.TestLastIndexOf2One("hello", "phrase hhello phrase", 3);
            this.TestLastIndexOf2One("", "hello phrase", 3);
            this.TestLastIndexOf2One("", "", 0);
            this.TestLastIndexOf2One("hello", "", 0);
        }

        private void TestLastIndexOfButton2_Click(object sender, EventArgs e)
        {
            this.TestLastIndexOf2();
        }

        private void TestSubStringOne(string str, int startIndex)
        {
            if (MyString.SubString(str, startIndex) != str.Substring(startIndex))
                MessageBox.Show(
                    String.Format("MyStrings.SubString bad result. " +
                    "str '{1}',my result '{2}', good result '{3}', val '{4}'",
                    str, MyString.SubString(str, startIndex), str.Substring(startIndex), startIndex)
               );
        }

        private void TestSubString()
        {
            this.TestSubStringOne("This is my first Project.Hello world.how are you", 17);
            this.TestSubStringOne("This is my first Project.Hello world.how are you", 10);
            this.TestSubStringOne("you", 2);
            this.TestSubStringOne("This is my first Project.Hello world.how are you", 0);
        }

        private void SubStringButton_Click(object sender, EventArgs e)
        {
            this.TestSubString();
        }

        private void TestSubString2One(string str, int startIndex, int length)
        {
            if (MyString.SubString(str, startIndex, length) != str.Substring(startIndex, length))
                MessageBox.Show(
                    String.Format("MyStrings.SubString bad result. " +
                    "str '{1}',my result '{2}', good result '{3}', val '{4}'",
                    str, MyString.SubString(str, startIndex, length), str.Substring(startIndex, length), startIndex)
               );
        }

        private void TestSubString2()
        {

            this.TestSubString2One("This is my first Project Hello world how are you", 17, 5);
            this.TestSubString2One("This is myfirst Project Hello world how are you", 10, 2);
            this.TestSubString2One("howare you", 3, 1);
            this.TestSubString2One("", 0, 0);
            this.TestSubString2One("This is my first Project.Hello world how are you", 0, 5);
        }

        private void SubStringButton2_Click(object sender, EventArgs e)
        {
            this.TestSubString2();
        }

        private void TestArrayCompareOne(string[] strArray1, string[] strArray2, bool real)
        {
            bool arrcomp = MyString.ArrayCompare(strArray1, strArray2) == real;
            if (!arrcomp)
                MessageBox.Show(String.Format("MyStrings my result '{0}', good result '{1}'",
                                MyString.ArrayCompare(strArray1, strArray2),
                                real)
                );
        }

        private void TestArrayCompare()
        {
            this.TestArrayCompareOne(new string[] { "hello", "world", "This", "Program" },
                                     new string[] { "hello", "world", "This", "Program" }, true);

            this.TestArrayCompareOne(new string[] { "hello", "world", "This", "Program" },
                                     new string[] { "hell ", "world", "This", "Program" }, false);

            this.TestArrayCompareOne(new string[] { "hello", "world", "", "Program" },
                                     new string[] { "hello", "world", "This", "Program" }, false);

            this.TestArrayCompareOne(new string[] { "", "s", "", "s" },
                                     new string[] { "s", "", "s", "" }, false);

            this.TestArrayCompareOne(new string[] { "", "", "", "" },
                                     new string[] { "", "", "" }, false);

            this.TestArrayCompareOne(new string[] { "", "", "" },
                                     new string[] { "", "", "" }, true);

            this.TestArrayCompareOne(new string[] { "hello", "world", "This", "Program" },
                                     new string[] { "he ll", "world", "This", "Program" }, false);

            this.TestArrayCompareOne(new string[] { "werw", "wrwer", "" },
                                     new string[] { "werw", "wrwer", "" }, true);

        }

        private void ArrayCompareButton_Click(object sender, EventArgs e)
        {
            this.TestArrayCompare();
        }

        private void TestSplitOne(string delimiter, string str)
        {
            bool ArrayCompare = MyString.ArrayCompare(MyString.Split(str, delimiter), str.Split(new string[] { "," }, StringSplitOptions.None));
            if (!ArrayCompare)
                MessageBox.Show(
                    String.Format("MyStrings my result '{0}', good result '{1}'",
                     MyString.Join("|", MyString.Split(str, delimiter)), MyString.Join("|", str.Split(new string[] { "," }, StringSplitOptions.None))));
        }

        private void TestSplit()
        {
            this.TestSplitOne(",", "Th,is ,is, my, s");
            this.TestSplitOne(",", "Th,is ,is, my,s fi,rst,s p,rogr,ams,  ");
            this.TestSplitOne(",", "  Th,is ,is, my,s fi,rst,s p,rogr,ams,");
            this.TestSplitOne(",", "");
            this.TestSplitOne(",", "T");
            this.TestSplitOne(",", "Th,is ,is, my,s fi,rst,s p,rogr,ams,");
            this.TestSplitOne(",", "Th,is ,is,, my,s fi,rst,s p,rogr,ams,");
            this.TestSplitOne(",", ",Th,is ,is, my,s fi,rst,s p,rogr,ams,");
            this.TestSplitOne(",", "This is mys firsts programs");
        }

        private void SplitButton_Click(object sender, EventArgs e)
        {
            this.TestSplit();
        }

        private void TestJoinOne(string delimiter, string[] arr)
        {
            if (MyString.Join(delimiter, arr) != String.Join(delimiter, arr))
                MessageBox.Show(
                    String.Format("MyStrings my result '{0}', good result '{1}'",
                     MyString.Join(delimiter, arr), String.Join(delimiter, arr))
               );
        }
        private void TestJoin()
        {
            this.TestJoinOne("|", new string[] { "Th", "is ", "is", " my", "s fi", "rst", "s p", "rogr", "ams,", "" });

            this.TestJoinOne("|", new string[] { "Th", "is ", "", "", "s fi", "", "s p", "rogr", "ams,", "" });

            this.TestJoinOne("|", new string[] { "Th", "is ", "is", " my", "s fi", "rst", "s p", "rogr", "ams,", "" });

            this.TestJoinOne("|", new string[] { "", "", "", " my", "s fi", "rst", "s p", "rogr", "ams,", "" });

            this.TestJoinOne("|", new string[] { "", "", "" });

            this.TestJoinOne("|", new string[] { "Th", "is ", "is", " my", "s fi", "rst", "s p", "rogr", "ams," });

            this.TestJoinOne("|", new string[] { });
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            this.TestJoin();
        }

        private void TestAddToArrayOne(string[] strArray, string str, int index, string[] arr)
        {
            bool ac = MyString.ArrayCompare(MyString.AddToArray(strArray, str, index), arr);
            if (!ac)
                MessageBox.Show(String.Format("MyStrings my result '{0}', good result '{1}'",
                                MyString.Join("|", MyString.AddToArray(strArray, str, index)), MyString.Join("|", arr))
                );
        }

        private void TestAddToArray()
        {
            this.TestAddToArrayOne(new string[] { "this is", "cool" }, "interest", 1,
                                   new string[] { "this is", "interest", "cool" });

            this.TestAddToArrayOne(new string[] { "this is", "cool" }, "interest", 0,
                                   new string[] { "interest", "this is", "cool" });

            this.TestAddToArrayOne(new string[] { "this is", "cool" }, " ", 1,
                                   new string[] { "this is", " ", "cool" });

            this.TestAddToArrayOne(new string[] { }, "this", 0,
                                   new string[] { "this" });

            this.TestAddToArrayOne(new string[] { }, "", 0,
                                   new string[] { "" });
        }

        private void AddToArrayButton_Click(object sender, EventArgs e)
        {
            this.TestAddToArray();
        }

        private void TestDelFromArrayOne(string[] strArray, int index, string[] arr)
        {
            bool ac = MyString.ArrayCompare(MyString.DelFromArray(strArray, index), arr);
            if (!ac)
                MessageBox.Show(String.Format("MyStrings my  '{0}', good  '{1}'",
                                MyString.Join("|", MyString.DelFromArray(strArray, index)), MyString.Join("|", arr))
                );
        }

        private void TestDelFromArray()
        {
            this.TestDelFromArrayOne(new string[] { "this", "is", "my", "first", "steps", "in", "IT world" }, 3,
                                     new string[] { "this", "is", "my", "steps", "in", "IT world" });

            this.TestDelFromArrayOne(new string[] { "", "is", "my", "first", "steps", "in", "IT world" }, 0,
                                     new string[] { "is", "my", "first", "steps", "in", "IT world" });

            this.TestDelFromArrayOne(new string[] { "", "", "", "", "", "", "" }, 4,
                                     new string[] { "", "", "", "", "", "" });

            this.TestDelFromArrayOne(new string[] { "this", "is", "my", "first", "steps", "in", "IT world" }, 6,
                                     new string[] { "this", "is", "my", "first", "steps", "in" });

            this.TestDelFromArrayOne(new string[] { "this", "is", "my", "first", "steps", "in", "IT world" }, 7,
                                     new string[] { "this", "is", "my", "first", "steps", "in", "IT world" });
        }

        private void DelFromArrayButton_Click(object sender, EventArgs e)
        {
            this.TestDelFromArray();
        }


        private void TestArraySortSelectionOne(int[] ArrayIn, MyArraySortDirection direction)
        {
            MyArray<int>.ArraySortSelection(ArrayIn, direction);
            for (int i = 0; i < ArrayIn.Length; i++)
            {
                MessageBox.Show(ArrayIn[i].ToString());
            }
        }

        private void TestArraySortSelectionOne()
        {
            this.TestArraySortSelectionOne(new int[] { 5, 7, 3, 9, 2, 4, 1, 6, 8 },
                                               MyArraySortDirection.HightToLow);

            /*I this.TestOrganizeArrayIncrementOne(new int[] { 5, 7, 3, 9, 2, 4, 1, 6, 8 });
             this.TestOrganizeArrayIncrementOne(new int[] { 5, 7, 3, 9, 5, 4, 1, 2, 8 });
             this.TestOrganizeArrayIncrementOne(new int[] { 1, 1, 1, 1, 2, 2, 1, 2, 2 });
             this.TestOrganizeArrayIncrementOne(new int[] {  });
             this.TestOrganizeArrayIncrementOne(new int[10] {0,-5,0, 5, 9, 2, 4, 1, 6, 8 });*/
        }


        private void ArraySortMyButton_Click(object sender, EventArgs e)
        {
            this.TestArraySortSelectionOne();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Summa(0).ToString());
        }

        private static readonly int[] arr = new int[] {1, 2, 3, 4, 5,};
        internal static int Summa(int x)
        {
            var sum = 0;
            var temp = 0;
            if (x + 1 == arr.Length)
                return arr[arr.Length - 1];

            temp = Summa(x + 1);
            sum = arr[x] + temp;
            return sum;
        }

        internal static int SummaVH(int x)
        {
            if (x == arr.Length - 1)
                return arr[x];
            else
                return arr[x] + SummaVH(x + 1);
        }

        internal static int Sum()
        {
            var sum = 0;
            for (int i = 0; i < arr.Length; i++)
               sum += arr[i];
            return sum;
        }

        public static int[] randomArray = RandomArray(1000 * 1000);
        public static List<int> myList = GetList();
        public static Dictionary<int, int> myDicttionary = GetDictionary();
        public static Collection<int> myCollection = GetCollection();

        public static int[] RandomArray(int count)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int digit = 0;
            Random ranDigit = new Random();
            int addedCount = 0;
            while (addedCount < count)
            {
                digit = ranDigit.Next();
                if (!dict.ContainsKey(digit))
                {
                    dict[digit] = digit;
                    addedCount++;
                }
            }
            return dict.Keys.ToArray<int>();
        }

        private void TestAddTimeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AddToArray" + Time(AddToArrayTest));
            MessageBox.Show("AddToList" + Time(AddTolistTest));
            MessageBox.Show("AddToDictionary" + Time(AddToDictionaryTest));
            MessageBox.Show("AddToCoolection" + Time(AddToCollectionTest));

        }

        internal static void AddToArrayTest()
        {
            int[] array = new int[randomArray.Length];
            for (int i = 0; i < randomArray.Length; i++)
                array[i] = randomArray[i];
        }

        internal static void AddTolistTest()
        {
            List<int> myList = new List<int>();
            for (int i = 1; i < randomArray.Length; i++)
                myList.Add(randomArray[i]);

        }

        internal static List<int> GetList()
        {
            List<int> myList = new List<int>();
            for (int i = 1; i < randomArray.Length; i++)
                myList.Add(randomArray[i]);
            return myList;
        }

        internal static void AddToDictionaryTest()
        {
            Dictionary<int, int> myDicttionary = new Dictionary<int, int>();
            for (int i = 1; i < randomArray.Length; i++)
                myDicttionary.Add(randomArray[i], randomArray[i]);

        }

        internal static Dictionary<int,int> GetDictionary()
        {
            Dictionary<int, int> myDicttionary = new Dictionary<int, int>();
            for (int i = 1; i < randomArray.Length; i++)
                myDicttionary.Add(randomArray[i], randomArray[i]);
            return myDicttionary;
        }

        internal static void AddToCollectionTest()
        {
            Collection<int> myCollection = new Collection<int>();
            for (int i = 1; i < randomArray.Length; i++)
                myCollection.Add(randomArray[i]);
        }

        internal static Collection<int> GetCollection()
        {
            Collection<int> myCollection = new Collection<int>();
            for (int i = 1; i < randomArray.Length; i++)
                myCollection.Add(randomArray[i]);
            return myCollection;
        }

        delegate void Method();

        private string Time(Method method)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            method();
            watch.Stop();
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                watch.Elapsed.Hours, watch.Elapsed.Minutes, watch.Elapsed.Seconds,
                watch.Elapsed.Milliseconds / 10);
            return elapsedTime;
        }
        

        private void TestSearchTimeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SearchInArray" + Time(SearchInArray));
            MessageBox.Show("SearchInList" + Time(SearchInlist));
            MessageBox.Show("SearchInDictionary" + Time(SearchInDictionary));
            MessageBox.Show("SearchInCollection" + Time(SearchInCollection));
            
        }
                
        private void SearchInArray()
        {
            Random ran = new Random();
            int searchDigits = 0;
            int result = 0;
            for (int j = 1; j < 1000; j++)
            {
                searchDigits = ran.Next();
                for (int k = 0; k < randomArray.Length; k++)
                    if (randomArray[k] == searchDigits)
                        result++;
            }
        }

        private void SearchInlist()
        {
            Random Ran = new Random();
            int digit = 0;
            int result = 0;
            for (int j = 1; j < 1000; j++)
            {
                digit = Ran.Next();
                if (!myList.Contains(digit))
                    result++;
            }
        }

        private void SearchInDictionary()
        {
            Random ran = new Random();
            int digit = 0;
            int chus = 0;
            for (int j = 1; j < 1000; j++)
            {
                digit = ran.Next();
                if (!myDicttionary.ContainsKey(digit))
                    chus++;
            }
        }

        private void SearchInCollection()
        {
            Random ran = new Random();
            int digit = 0;
            int chus = 0;
            for (int j = 1; j < 1000; j++)
            {
                digit = ran.Next();
                if (!myCollection.Contains(digit))
                    chus++;
            }
        }
    }
}