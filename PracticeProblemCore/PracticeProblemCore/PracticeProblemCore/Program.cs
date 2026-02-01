internal class Program
{
    static void Main(string[] args)
    {
        #region Priorty Queue
        //int[][] points = [[1, 3], [-2, 2]];
        //int k = 1;
        //int[][] result = KClosest(points, k);
        //Console.WriteLine(
        //    string.Join(", ",
        //        result.Select(p => $"[{p[0]}, {p[1]}]"))
        //);


        int[] nums = { 3, 2, 1, 5, 6, 4 };
        int kLargest = 2;
        Console.WriteLine(FindKthLargest(nums, kLargest));
        #endregion

    }
    #region PRIORITY QUEUE
    public static int[][] KClosestAnswer(int[][] points, int k)
    {
        PriorityQueue<int[], int> pq = new PriorityQueue<int[], int>();

        foreach (var p in points)
        {
            int dist = p[0] * p[0] + p[1] * p[1];

            pq.Enqueue(p, -dist);

            if (pq.Count > k)
                pq.Dequeue();
        }

        int[][] result = new int[k][];

        for (int i = 0; i < k; i++)
            result[i] = pq.Dequeue();

        return result;
    }

    public static int[][] KClosest(int[][] points, int k)
    {
        PriorityQueue<int[], int> pq = new PriorityQueue<int[], int>();

        foreach (var p in points)
        {
            int dist = p[0] * p[0] + p[1] * p[1];

            pq.Enqueue(p, -dist);

            if (pq.Count > k)
                pq.Dequeue();
        }

        int[][] result = new int[k][];
        for (int i = 0; i < k; i++)
            result[i] = pq.Dequeue();


        return result;
    }

    public static int FindKthAnswer(int[] nums, int k)
    {
        // Min-heap
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

        foreach (int num in nums)
        {
            pq.Enqueue(num, num);

            if (pq.Count > k)
            {
                pq.Dequeue(); // Remove smallest
            }
        }

        return pq.Peek(); // Kth largest
    }

    public static int FindKthLargest(int[] nums, int k)
    {
        return 1;
    }

    #endregion

}

