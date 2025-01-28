/* //int a=12345678 priont a=43218765
// a=87654321

public class Task2 {
	
	private static int DigitCount(int num) {
		int cnt = 0;
		while(num > 0) {
			cnt++;
			num /= 10;
		}
		
		return cnt;
	}
	
	private static int[] Store(int num) {
		int len = DigitCount(num);
		
		int[] arr = new int[len];
		int idx = 0;
		
		while(num > 0) {
			int rem = num % 10;
			arr[idx++] = rem;
			num /= 10;
		}
		
		return arr;
	}
	
	//1234
	
	private static void Compute(int[] arr) {
		int mid = arr.Length / 2;
		int res = 0;
		
		for(int i=mid; i<arr.Length; i++) {
			res =  ( res * 10 ) + arr[i];
		}
		
		for(int i=0; i<mid; i++) {
			res =  ( res * 10 ) + arr[i];
		}
		
		Console.Write($"The num is: {res}");
	}
	
	public static void Main(string[] args) {
		Console.Write("Enter a num: ");
		int n = Convert.ToInt32(Console.ReadLine());
		
		int cnt = DigitCount(n);
		int[] arr = Store(n);
		Compute(arr);
	}
} */