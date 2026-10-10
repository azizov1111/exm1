// task 1
// int a = Convert.ToInt32(Console.ReadLine());
// int[] po = new int[a];
// for (int i = 0; i < a; i++)
// {
//     po[i] = Convert.ToInt32(Console.ReadLine());
// }
// int k = Convert.ToInt32(Console.ReadLine());
// for (int i = k; i < a - 1; i++)
// {
//     po[i] = po[i + 1];
// }
// for (int i = 0; i < a - 1; i++)
// {
//     Console.WriteLine(po[i]);
// }




// task2
// int n=Convert.ToInt32(Console.ReadLine());
    
//     int cnt=0;
//    int [] num = new int [n];
//    for(int i = 0; i < n; i++)
// {
//     num[i]=Convert.ToInt32(Console.ReadLine());
// }
//  for(int i = 0; i < n; i++)
// {
//     if(num[i]%2==0) cnt++;
// }
// int cntodd=0;
//  for(int i = 0; i < n; i++)
// {
//     if(num[i]%2!=0) cntodd++;
// }
// int cntdigit=0;
//  for(int i = 0; i < n; i++)
// {
//     if(num[i]<10) cntdigit++;
// }
// int sum=0;
//  for(int i = 0; i < n; i++)
// {
//     sum+=num[i];
// }
// System.Console.WriteLine(cnt);
// System.Console.WriteLine(cntodd);
// System.Console.WriteLine(cntdigit);
// System.Console.WriteLine(sum);









// task3
// int a=Convert.ToInt32(Console.ReadLine());
// int b=0;
// for(int i = a; i > 0; i /= 10)
// {
//     b=b*10+i%10;
// }
// if (a == b)
// {
//     System.Console.WriteLine("YES");
// }
// else
// {
//     System.Console.WriteLine("NO");
// }


// task4
//  static int SumOfDigits(int n)
// {

// int sum=0;
// while (n > 0)
// {
//     sum+=n%10;
//     n/=10;
// }
// return sum;
// }
// int n=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("The sum of the digits of the number " + n + " is : " +  SumOfDigits(n));



// task 5
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];
// for(int i=0; i<a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// void P(ref int[] arr, int n, int a)
// {
//     for (int i = 0; i < a; i++)
//     {
//         arr[i] = arr[i] + n;
//     }
// }   
// int n = Convert.ToInt32(Console.ReadLine());

// P(ref arr, n, a);

// for (int i = 0; i < a; i++)
// {
//     Console.Write(arr[i] + " ");
// }

// task6
// void Swap(ref int a, ref int b)

// {
//     int c=a;
//     a=b;
//     b=c;

// }

// int a=Convert.ToInt32(Console.ReadLine());
// int b=Convert.ToInt32(Console.ReadLine());
// Swap(ref a, ref b);
// System.Console.WriteLine("x = " + a);
// System.Console.WriteLine("y = " + b);








// task 7
// int a = Convert.ToInt32(Console.ReadLine());
// int SumDigit(int a )
// {
//     if(a == 0 )
//     {
//         return 0;
//     }
//     return a%10 + SumDigit(a/10);
// }
// System.Console.WriteLine(SumDigit(a));


// task8
// string ab(string t, int a)
// {
//     if (a == 0) return "";
//     return t + ab(t, a - 1);
// }

// Console.WriteLine(ab("cherry", 2));