//Remove dublicates from arr without creating new arr


// 1 1 1 2 3 4 4 5

public class Dublicates {
	
	private static void Compute(int[] arr) {
		int i = 0;
		int j = 1;
		
		while(i < arr.Length && j < arr.Length) {
			if(arr[i] == arr[j]) {
				arr[j] = 0;
				j++;
			} else {
				i = j;
				j++;
			}
		}
		
		int idx = 0;
		int si = 0;
		
		while(si < arr.Length && idx < arr.Length) {
			if(arr[si] == 0) {
				idx = si;
				si++;
			} else {
				arr[idx] = arr[si];
				idx++;
				si++;	
			}
			
		}
		
		foreach(int z in arr) {
			Console.Write(z + "  ");
		}
	}
	
	public static void Main(string[] args) {
		Console.Write("Enter the size of an array: ");
		int n = Convert.ToInt32(Console.ReadLine());
		
		int[] arr = new int[n];
		
		Console.Write("Enter the all the elements: ");
		for(int i=0; i<arr.Length; i++) {
			arr[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		Compute(arr);
	}
}