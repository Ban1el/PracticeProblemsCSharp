using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sockMerchant(9, new List<int>() { 10, 20, 20, 10, 10, 30, 50, 10, 20 });
            //Console.WriteLine(sockMerchantAnswer(9, new List<int>() { 10, 20, 20, 10, 10, 30, 50, 10, 20 }));
            //Console.WriteLine(jumpingOnCloudsAnswer(new List<int> { 0, 0, 1, 0, 0, 1, 0 }));
            //Console.WriteLine(jumpingOnCloudsAnswer(new List<int> { 0, 1, 0, 1, 0 }));
            //Console.WriteLine(jumpingOnCloudsAnswer(new List<int> { 0, 0, 0, 1, 0, 0 }));
            //Console.WriteLine(repeatedString("aba", 10));
            //Console.WriteLine(repeatedStringAnswer("aba", 10));
            //Console.WriteLine(hourglassSum(new List<List<int>>
            //{
            //    new List<int> { -9, -9, -9,  1, 1, 1 },
            //    new List<int> {  0, -9,  0,  4, 3, 2 },
            //    new List<int> { -9, -9, -9,  1, 2, 3 },
            //    new List<int> {  0,  0,  8,  6, 6, 0 },
            //    new List<int> {  0,  0,  0, -2, 0, 0 },
            //    new List<int> {  0,  0,  1,  2, 4, 0 }
            //}));
            //minimumBribes(new List<int> { 2, 5, 1, 3, 4 });
            //minimumBribesAnswer(new List<int> { 2, 1, 5, 3, 4 });

            #region NON HACCKERRANK
            //Answer: [0, 1]
            //int[] result = TwoSumAnswer(new int[] { 2, 7, 11, 15 }, 9);
            //Console.WriteLine(string.Join(", ", result));

            //Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));

            #region MIDDLE LINKED LIST
            //Note: ListNode is the linked list but created manually
            //There is a C# version which is always doubly, this is a singly implementation
            //This is done for interview purposes, in an actual program, you use the inbuilt one
            // Create linked list: 1 -> 2 -> 3 -> 4 -> 5
            //ListNode head = new ListNode(1);
            //head.next = new ListNode(2);
            //head.next.next = new ListNode(3);
            //head.next.next.next = new ListNode(4);
            //head.next.next.next.next = new ListNode(5);
            //ListNode middle = MiddleNode(head);
            //Console.WriteLine("Middle node value: " + middle.val);
            // Output: Middle node value: 3
            #endregion

            #region MaxSubarraySum (Sliding window fixed range)
            //Console.WriteLine(MaxSubarraySumAnswer(new int[] { 1, 2, 3, 7, 4, 1 }, 3));
            #endregion

            #region LengthOfLongestSubstring (Sliding window dynamic range)
            //Output: 2
            //Console.WriteLine(LengthOfLongestSubstringAnswer("aaaabaaa"));
            //Console.WriteLine(LengthOfLongestSubstringAnswer("abba")); 

            #endregion

            #region BinarySearch
            //Console.WriteLine(BinarySearchAnswer(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 4));
            //Console.WriteLine(FirstTrueAnswer(new bool[] { false, false, false, true, true, true }));
            #endregion

            #region VALID PALINDROME (Using Opposite Direction Two pointer)
            //Output: True
            //Console.WriteLine(IsPalindromeAnswer("A man, a plan, a canal: Panama"));
            //Output: False
            //Console.WriteLine(IsPalindromeAnswer("race a car"));
            #endregion

            #region MiddleNodeAnswer
            //Create sample list: 1-> 2-> 3-> 4-> 5
            ListNodeAnswer n1 = new ListNodeAnswer(1);
            ListNodeAnswer n2 = new ListNodeAnswer(2);
            ListNodeAnswer n3 = new ListNodeAnswer(3);
            ListNodeAnswer n4 = new ListNodeAnswer(4);
            ListNodeAnswer n5 = new ListNodeAnswer(5);

            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;

            ListNodeAnswer head = n1;

            //ListNodeAnswer middle = MiddleNodeAnswer(head);

            //Console.WriteLine(middle.val); // Output: 3
            #endregion

            #region BFS
            #region TREE
            //TreeNodeAnswer root =
            //    new TreeNodeAnswer(1,
            //        new TreeNodeAnswer(2,
            //            new TreeNodeAnswer(4), new TreeNodeAnswer(5)),
            //                new TreeNodeAnswer(3,
            //                    null, new TreeNodeAnswer(6))
            //);
            //TreeBFSAnswer(root);
            #endregion
            #region GRAPH
            // Sample graph
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>()
            {
                {1, new List<int>{2, 3}},
                {2, new List<int>{1, 4, 5}},
                {3, new List<int>{1, 6}},
                {4, new List<int>{2}},
                {5, new List<int>{2}},
                {6, new List<int>{3}}
            };

            //GraphBFSAnswer(graph, 1);  // Output: 1 2 3 4 5 6
            #endregion
            #region LEVEL ORDER
            // Build the tree
            //TreeNode root = new TreeNode(1)
            //{
            //    left = new TreeNode(2)
            //    {
            //        left = new TreeNode(4)
            //        {
            //            right = new TreeNode(7)
            //        },
            //        right = new TreeNode(5)
            //    },
            //    right = new TreeNode(3)
            //    {
            //        right = new TreeNode(6)
            //    }
            //};
            ////Output: [[1], [2, 3], [4, 5, 6], [7]]
            //IList<IList<int>> result = LevelOrderAnswer(root);
            //Console.Write("[");

            //for (int i = 0; i < result.Count; i++)
            //{
            //    Console.Write("[");
            //    Console.Write(string.Join(", ", result[i]));
            //    Console.Write("]");

            //    if (i < result.Count - 1)
            //        Console.Write(", ");
            //}

            //Console.WriteLine("]");
            #endregion
            #region FLOOD FILL (SIMULATING PAINT BUCKET TOOL)
            int[][] image = new int[][]
           {
                new int[] {1, 1, 1},
                new int[] {1, 1, 0},
                new int[] {1, 0, 1}
           };

            int sr = 1, sc = 1, newColor = 2;

            //int[][] result = FloodFillAnswer(image, sr, sc, newColor);

            // Print result
            //Console.WriteLine("Flood Fill Result:");
            //for (int i = 0; i < result.Length; i++)
            //{
            //    for (int j = 0; j < result[i].Length; j++)
            //    {
            //        Console.Write(result[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #endregion

            #region DFS
            TreeNode root = new TreeNode() {
                val = 20,
                left = new TreeNode()
                {
                    val = 14,
                    left = new TreeNode()
                    {
                        val = 11
                    },
                    right = new TreeNode()
                    {
                        val = 16
                    }
                },
                right = new TreeNode()
                {
                    val = 24,
                    left = new TreeNode()
                    {
                        val = 27
                    },
                    right = new TreeNode()
                    {
                        val = 29
                    }
                }
            };

            TreeNode node = TreeDFSAnswer(root, 29);
            Console.WriteLine(node.val);
            #endregion
            #endregion


            Console.ReadLine();
        }

        #region (SALES BY MATCH) sockMerchant
        public static int sockMerchant(int n, List<int> ar)
        {
            //Dictionary<int, int> kvp = new Dictionary<int, int>();
            //int pairs = 0;

            //foreach (int val in ar)
            //{
            //    if (kvp.ContainsKey(val))
            //    {
            //        kvp[val]++;
            //    }
            //    else
            //    {
            //        kvp[val] = 1;
            //    }
            //}

            //foreach (int socks in kvp.Values)
            //{
            //    pairs += socks / 2;
            //}

            //return pairs;
            return 1;
        }

        public static int sockMerchantAnswer(int n, List<int> ar)
        {
            return 1;
        }
        #endregion

        #region (COUNTING VALLEYS) countingValleys
        public static int countingValleys(int steps, string path)
        {
            int altitude = 0, count = 0;

            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'U')
                {
                    if (altitude == -1)
                    {
                        count++;
                    }

                    altitude++;
                }
                else if (path[i] == 'D')
                {
                    altitude--;
                }
            }

            return count;
        }

        public static int countingValleysAnswer(int steps, string path)
        {
            int count = 0, altitude = 0;

            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'U')
                {
                    if (altitude == -1)
                    {
                        count++;
                    }

                    altitude++;
                }
                else if (path[i] == 'D')
                {
                    altitude--;
                }
            }

            return count;
        }
        #endregion

        #region (JUMPING ON THE CLOUDS) jumpingOnClouds
        public static int jumpingOnClouds(List<int> c)
        {
            int count = 0, i = 0;

            while (i < c.Count - 1)
            {
                if (i + 2 < c.Count && c[i + 2] == 1)
                {
                    i++;
                }
                else
                {
                    i += 2;
                }

                count++;
            }

            return count;
        }

        public static int jumpingOnCloudsAnswer(List<int> c)
        {
            return 1;
        }
        #endregion

        #region RepeatedString
        public static long repeatedString(string s, long n)
        {
            //long repeatNTimes = n / s.Length;
            //long remainder = n % s.Length;
            //long counter = 0;

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] == 'a') counter++;
            //}

            //counter *= repeatNTimes;

            //for (int i = 0; i < remainder; i++)
            //{
            //    if (s[i] == 'a') counter++;
            //}

            //return counter;
            return 1;
        }

        public static long repeatedStringAnswer(string s, long n)
        {
            long remainder = n % s.Length;
            long noOfTimes = n / s.Length;
            long count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a') count++;
            }

            count *= noOfTimes;

            for (int i = 0; i < remainder; i++)
            {
                if (s[i] == 'a') count++;
            }

            return count;
        }
        #endregion

        #region 2D Array - DS (hourglassSum)
        public static int hourglassSum(List<List<int>> arr)
        {
            //int maxSum = int.MinValue;
            //int rows = arr.Count();
            //int columns = arr[0].Count();

            //for (int i = 0; i < rows - 2; i++)
            //{
            //    for (int j = 0; j < columns - 2; j++)
            //    {
            //        int currentMaxValue = 
            //            arr[i][j] +
            //            arr[i][j + 1] +
            //            arr[i][j + 2] +
            //            arr[i + 1][j + 1] +
            //            arr[i + 2][j] +
            //            arr[i + 2][j + 1] +
            //            arr[i + 2][j + 2];

            //        maxSum = Math.Max(maxSum, currentMaxValue); 
            //    }
            //}

            //return maxSum;
            return 1;
        }

        public static int hourglassSumAnswer(List<List<int>> arr)
        {
            int row = arr.Count;
            int column = arr[0].Count;
            int maxSum = int.MinValue;

            for (int i = 0; i < row - 2; i++)
            {
                for (int j = 0; j < column - 2; j++)
                {
                    int sum =
                        arr[i][j] +
                        arr[i][j + 1] +
                        arr[i][j + 2] +
                        arr[i + 1][j + 1] +
                        arr[i + 2][j] +
                        arr[i + 2][j + 1] +
                        arr[i + 2][j + 2];

                    maxSum = Math.Max(maxSum, sum);
                }
            }

            return maxSum;
        }
        #endregion

        #region NEW YEAR CHAOS (Minimum Bribes)
        public static void minimumBribes(List<int> q)
        {
            //int count = 0;

            //// 2, 5, 1, 3, 4
            //// 2, 1, 5, 3, 4
            //for (int i = 0; i < q.Count; i++)
            //{
            //    if (q[i] - (i + 1) > 2)
            //    {
            //        Console.WriteLine("Too chaotic");
            //        return;
            //    }
            //    else
            //    {
            //        for (int j = Math.Max(0, q[i] - 2); j < i; j++)
            //        {
            //            if (q[j] > q[i]) count++;
            //        }
            //    }
            //}

            //Console.WriteLine(count);
        }

        public static void minimumBribesAnswer(List<int> q)
        {
            // 2, 5, 1, 3, 4
            // 2, 1, 5, 3, 4
            int count = 0;

            for (int i = 0; i < q.Count; i++)
            {
                if (q[i] - (i + 1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                else
                {
                    for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                    {
                        if (q[j] > q[i]) count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
        #endregion

        #region TWO SUM
        public static int[] TwoSum(int[] nums, int target)
        {
            //Dictionary<int, int> num_to_index = new Dictionary<int, int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int complement = target - nums[i];

            //    if (num_to_index.ContainsKey(complement))
            //    {
            //        return new int[] { num_to_index[complement], i };
            //    }

            //    if (!num_to_index.ContainsKey(nums[i])) num_to_index.Add(nums[i], i);
            //}

            return Array.Empty<int>();
        }

        public static int[] TwoSumAnswer(int[] nums, int target)
        {
            return Array.Empty<int>();
        }

        //Array.Empty<int>()
        #endregion

        #region VALID PALINDROME (Using Opposite Direction Two pointer)
        public static bool IsPalindrome(string s)
        {
            //int left = 0;
            //int right = s.Length - 1;

            //while (left < right)
            //{
            //    while (left < right && !char.IsLetterOrDigit(s[left]))
            //        left++;

            //    while (left < right && !char.IsLetterOrDigit(s[right]))
            //        right--;

            //    if (char.ToLower(s[left]) != char.ToLower(s[right]))
            //        return false;

            //    left++;
            //    right--;
            //}

            return true;
        }

        public static bool IsPalindromeAnswer(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                while (left < right && !char.IsLetterOrDigit(s[left]))
                    left++;
                while (left < right && !char.IsLetterOrDigit(s[right]))
                    right--;

                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                    return false;

                left++;
                right--;
            }

            return true;
        }
        #endregion

        #region MIDDLE OF A LINKED LIST (TWO POINTER)
        // Note: ListNode is the LinkedList, but its self created
        // Reason for this is to see it clearly without the abstractions
        // This is only done for interview purposes, and in an actual program, you use the inbuilt ones
        // This is a singly linked list
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode MiddleNode(ListNode head)
        {
            //Two pointer, same direction
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }

        public class ListNodeAnswer
        {
            public int val;
            public ListNodeAnswer next;

            public ListNodeAnswer(int val = 0, ListNodeAnswer next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNodeAnswer MiddleNodeAnswer(ListNodeAnswer head)
        {
            ListNodeAnswer slow = head;
            ListNodeAnswer fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }
        #endregion

        #region MaxSubarraySum (Sliding window fixed range)
        public static int MaxSubarraySum(int[] nums, int k)
        {
            //nums = [1, 2, 3, 7, 4, 1] k = 3
            //output: 14
            //int windowSum = 0;
            //int maxSum = int.MinValue;
            //int left = 0;

            //for (int right = 0; right < nums.Length; right++)
            //{
            //    windowSum += nums[right];

            //    if (right - left + 1 == k)
            //    {
            //        maxSum = Math.Max(maxSum, windowSum);
            //        windowSum -= nums[left];
            //        left++;
            //    }
            //}

            //return maxSum;
            return 1;
        }

        public static int MaxSubarraySumAnswer(int[] nums, int k)
        {
            return 1;
        }

        #endregion

        #region LengthOfLongestSubstring (Sliding window dynamic range)
        public static int LengthOfLongestSubstring(string s)
        {
            //HashSet<char> set = new HashSet<char>();
            //int left = 0;
            //int maxLength = 0;

            //for (int right = 0; right < s.Length; right++)
            //{
            //    while (set.Contains(s[right]))
            //    {
            //        set.Remove(s[left]);
            //        left++;
            //    }

            //    set.Add(s[right]);
            //    maxLength = Math.Max(maxLength, right - left + 1);
            //}

            //return maxLength;
            return 1;
        }

        public static int LengthOfLongestSubstringAnswer(string s)
        {
            HashSet<char> set = new HashSet<char>();
            int left = 0;
            int maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }

                set.Add(s[right]);

                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }

        #endregion

        #region BINARY SEARCH
        public static int BinarySearch(int[] arr, int target)
        {
            //int left = 0;
            //int right = arr.Length - 1;

            //while (left <= right)
            //{
            //    int mid = left + (right - left) / 2;

            //    if (arr[mid] == target)
            //        return mid;

            //    if (arr[mid] < target)
            //        left = mid + 1;
            //    else
            //        right = mid - 1;
            //}

            return -1; // not found
        }

        public static int BinarySearchAnswer(int[] arr, int target)
        {
            return -1;
        }

        public static int FirstTrue(bool[] arr)
        {
            //int left = 0;
            //int right = arr.Length - 1;
            //int boundryIndex = -1;

            //while (left <= right)
            //{
            //    int mid = left + (right - left) / 2;
            //    if (arr[mid])
            //    {
            //        boundryIndex = mid;
            //        right = mid - 1;
            //    }
            //    else
            //        left = mid + 1;

            //}

            return -1;
        }

        public static int FirstTrueAnswer(bool[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            int boundryIndex = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid])
                {
                    boundryIndex = mid;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return boundryIndex;
        }

        public static int FindMin(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                // Minimum is in the right half
                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    // Minimum is in the left half (including mid)
                    right = mid;
                }
            }

            // left == right → minimum index
            return nums[left];
        }

        #endregion

        #region Breadth-first search
        #region Tree Traversion
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public static void TreeBFS(TreeNode root)
        {
            //if (root == null) return;

            //Queue<TreeNode> queue = new Queue<TreeNode>();
            //queue.Enqueue(root);

            //while (queue.Count > 0)
            //{
            //    TreeNode current = queue.Dequeue();
            //    Console.Write(current.val + " ");

            //    if (current.left != null)
            //        queue.Enqueue(current.left);

            //    if (current.right != null)
            //        queue.Enqueue(current.right);
            //}
        }

        public class TreeNodeAnswer
        {
            public int val;
            public TreeNodeAnswer left;
            public TreeNodeAnswer right;

            public TreeNodeAnswer(int val = 0, TreeNodeAnswer left = null, TreeNodeAnswer right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public static void TreeBFSAnswer(TreeNodeAnswer root)
        {
            Queue<TreeNodeAnswer> queue = new Queue<TreeNodeAnswer>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNodeAnswer node = queue.Dequeue();
                Console.Write(node.val + " ");

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }
        }

        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            //if (root == null) return result;

            //Queue<TreeNode> queue = new Queue<TreeNode>();
            //queue.Enqueue(root);

            //while (queue.Count > 0)
            //{
            //    int levelSize = queue.Count;
            //    List<int> level = new List<int>();

            //    for (int i = 0; i < levelSize; i++)
            //    {
            //        TreeNode node = queue.Dequeue();
            //        level.Add(node.val);

            //        if (node.left != null)
            //            queue.Enqueue(node.left);

            //        if (node.right != null)
            //            queue.Enqueue(node.right);
            //    }

            //    result.Add(level);
            //}

            return result;
        }

        public static IList<IList<int>> LevelOrderAnswer(TreeNode root)
        {
            IList<IList<int>> levels = new List<IList<int>>();

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                List<int> level = new List<int>();
                int levelSize = queue.Count;
                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode node = queue.Dequeue();
                    level.Add(node.val);

                    if (node.left != null)
                        queue.Enqueue(node.left);

                    if (node.right != null)
                        queue.Enqueue(node.right);
                }

                levels.Add(level);
            }

            return levels;
        }

        #region FLOOD FILL (SIMULATING PAINT BUCKET TOOL)
        public static int[][] FloodFill(int[][] image, int startRow, int startCol, int newColor)
        {
            int originalColor = image[startRow][startCol];

            if (originalColor == newColor)
                return image;

            int rows = image.Length;
            int cols = image[0].Length;

            Queue<(int, int)> cellsToVisit = new Queue<(int, int)>();
            cellsToVisit.Enqueue((startRow, startCol));

            int[] rowOffset = { -1, 1, 0, 0 }; // up, down, left, right
            int[] colOffset = { 0, 0, -1, 1 };

            while (cellsToVisit.Count > 0)
            {
                var (row, col) = cellsToVisit.Dequeue();
                image[row][col] = newColor;

                for (int i = 0; i < 4; i++)
                {
                    int nextRow = row + rowOffset[i];
                    int nextCol = col + colOffset[i];

                    if (IsInside(nextRow, nextCol, rows, cols) &&
                        image[nextRow][nextCol] == originalColor)
                    {
                        cellsToVisit.Enqueue((nextRow, nextCol));
                    }
                }
            }

            return image;
        }

        public static int[][] FloodFillAnswer(int[][] image, int sr, int sc, int color)
        {
            int originalColor = image[sr][sc];

            if (originalColor == color)
                return image;

            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue((sr, sc));

            int rows = image.Length;
            int cols = image[0].Length;

            int[] rowOffset = { -1, 1, 0, 0 };
            int[] colOffset = { 0, 0, -1, 1 };

            while (queue.Count > 0)
            {
                var (row, col) = queue.Dequeue();
                image[row][col] = color;

                for (int i = 0; i < 4; i++)
                {
                    int goRow = row + rowOffset[i];
                    int goCol = col + colOffset[i];

                    if (goRow >= 0 &&
                        goCol >= 0 &&
                        goRow < rows &&
                        goCol < cols
                        && image[goRow][goCol] == originalColor)
                    {
                        queue.Enqueue((goRow, goCol));
                        image[goRow][goCol] = color;
                    }
                }
            }

            return image;
        }

        static bool IsInside(int row, int col, int rows, int cols)
        {
            return row >= 0 && row < rows && col >= 0 && col < cols;
        }
        #endregion

        #region Graph Traversion
        static void GraphBFS(Dictionary<int, List<int>> graph, int start)
        {
            //HashSet<int> visited = new HashSet<int>();
            //Queue<int> queue = new Queue<int>();

            //visited.Add(start);
            //queue.Enqueue(start);

            //while (queue.Count > 0)
            //{
            //    int node = queue.Dequeue();
            //    Console.Write(node + " ");

            //    foreach (int neighbor in graph[node])
            //    {
            //        if (!visited.Contains(neighbor))
            //        {
            //            visited.Add(neighbor);
            //            queue.Enqueue(neighbor);
            //        }
            //    }
            //}
        }

        static void GraphBFSAnswer(Dictionary<int, List<int>> graph, int start)
        {
            HashSet<int> nodeVisited = new HashSet<int>();
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);
            nodeVisited.Add(start);

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();

                Console.Write(node + " ");

                foreach (var children in graph[node])
                {
                    if (!nodeVisited.Contains(children))
                    {
                        nodeVisited.Add(children);
                        queue.Enqueue(children);
                    }
                }

            }
        }
        #endregion
        #endregion
        #endregion

        #region DEPTH FIRST SEARCH
        static TreeNode TreeDFS(TreeNode root, int target)
        {
            if (root == null)
                return null;

            if (root.val == target)
                return root;

            TreeNode left = TreeDFS(root.left, target);
            if (left != null)
                return left;

            return TreeDFS(root.right, target);
        }

        static TreeNode TreeDFSAnswer(TreeNode root, int target)
        {
            if (root == null)
                return null;

            if (root.val == target)
                return root;

            TreeNode left = TreeDFSAnswer(root.left, target);

            if(left != null)
                return left;

            return TreeDFSAnswer(root.right, target); 
        }

        #endregion
    }
}
