using System;

class Program {
    static void Main(string[] args) {
      int x = int.Parse(Console.ReadLine()) ;
      int count1=0, count2=0, count3=0, count4=0, count5=0, count6=0;
        int[] array=new int[x];
     Random rand = new Random();
      for(int i=0; array.Length>i; i++)
      {
        array[i]=rand.Next(1,7);
        if(array[i]==1)
        {
          count1++;
        }
        else if(array[i]==2)
        {
          count2++;
        }
        else if(array[i]==3)
        {
          count3++;
          }
        else if(array[i]==4)
        {
          count4++;
          }
        else if(array[i]==5)
        {
          count5++;
          }
        else if(array[i]==6)
        {
          count6++;
          }
      }

      /*for(int i=0; array.Length>i; i++)
      {
        Console.Write(array[i]+" ");
      }*/
      Console.WriteLine("\n"+"1: "+count1+" 2:"+" "+count2+" 3:"+" "+count3+" 4:"+" "+count4+" 5:"+" "+count5+" 6:"+" " +count6);
      
    }
  }