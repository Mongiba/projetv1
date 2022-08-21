using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/*{


     //public double time;
    // public string tim;


    // void game()
     //{
        // if (time == d-120)
         //{
        // tritab();
           //hamplus = 0;
         //tbarkaplus = 0;
         //sobhanaplus = 0;
         //}
         //else if (time == d)
         ///{

     //}
    /* public void tritab()
     {
         double duree = (f - d) * 3600;
         double[,] tab_hamdoulah = new double[2, hamdoulh];
         int i = 0;
         for (i = 0; i < hamdoulh; i++)
         {
             tab_hamdoulah[0, i] = numham;
             tab_hamdoulah[1, i] = 1;
             numham += (duree / (hamdoulh + 1));
             Debug.Log(tab_hamdoulah[0,i]);

         }



         double[,] tab_tbarklh = new double[2, tbarkalh];

         for (i = 0; i < tbarkalh; i++)
         {
             tab_tbarklh[0, i] = numtbarklh;
             tab_tbarklh[1, i] = 2;
             numtbarklh += (duree / (tbarkalh + 1));
             Debug.Log(tab_tbarklh[0, i]);
         }

         double[,] tab_sobhanlh = new double[2, sobhanalh];

         for (i = 0; i < tbarkalh; i++)
         {
             tab_sobhanlh[0, i] = numsobhanlh;
             tab_sobhanlh[1, i] = 3;
             numsobhanlh += (duree / (sobhanalh + 1));
             Debug.Log(tab_sobhanlh[0, i]);

         }








         tab_wa9et[0, 0] = d*3600;
         tab_wa9et[1, 0] = 0;



             for (i = 1; i <= hamdoulh + tbarkalh + sobhanalh + 1; i++)
             {
                 if (i <= hamdoulh)
                 {
                     tab_wa9et[0, i] = tab_hamdoulah[0, i - 1];
                     tab_wa9et[1, i] = tab_hamdoulah[1, i - 1];
                 }
                 else if ((i <= tbarkalh + hamdoulh) && (i > hamdoulh))
                 {
                     tab_wa9et[0, i] = tab_tbarklh[0, i - (1 + hamdoulh)];
                     tab_wa9et[1, i] = tab_tbarklh[1, i - (1 + hamdoulh)];
                 }
                 else if ((i <= tbarkalh + hamdoulh + sobhanalh) && (i > hamdoulh + tbarkalh))
                 {
                     tab_wa9et[0, i] = tab_sobhanlh[0, i - (1 + hamdoulh + tbarkalh)];
                     tab_wa9et[1, i] = tab_sobhanlh[1, i - (1 + hamdoulh + tbarkalh)];
                 }
                 else
                 {
                     tab_wa9et[0, hamdoulh + tbarkalh + sobhanalh + 1] = f*3600;
                     tab_wa9et[1, hamdoulh + tbarkalh + sobhanalh + 1] = 0;
                 }


             }sortBySelection(tab_wa9et, hamdoulh + tbarkalh + sobhanalh + 2);





             i = 0;
             int j = 1;

             while (i < tbarkalh + hamdoulh + sobhanalh + 1)

             {
                 if (tab_wa9et[0, i] == tab_wa9et[0, i + j])
                 {
                     while (tab_wa9et[0, i] == tab_wa9et[0, i + j])
                     {
                         j++;
                     }
                     double diff = (tab_wa9et[0, i + j] - tab_wa9et[0, i]) / j;
                     for (int k = 0; k < j; k++)
                     {
                         tab_wa9et[0, i + k] = tab_wa9et[0, i + k] + k * diff;
                     }
                 }
                 i++;
                 j = 1;
             }
         //for ( i = 0; i < hamdoulh + tbarkalh + sobhanalh + 2; i++)
         //{
          //   Debug.Log(tab_wa9et[0, i]);
            // Debug.Log(tab_wa9et[0, i]);


         //}
     }


         public void sortBySelection(double[,] t , int sizeOfTheCollection)
     {

         int i ,min, j;
      double x,y;
         for (i = 0; i < sizeOfTheCollection - 1; i++)
         {
             min = i;
             for (j = i + 1; j < sizeOfTheCollection; j++)
                 if (t[0,j] < t[0,min])
                     min = j;
             if (min != i)
             {
                 x = t[0,i];
                 t[0,i] = t[0,min];
                 t[0,min] = x;
                 y = t[1,i];
                 t[1,i] = t[1,min];
                 t[1,min] = y;


             }
         }

     }*/


  /*  void Update()
    {

        time = TimeToSeconds();

        double TimeToSeconds()
        {
            tim = DateTime.Now.ToString("H:mm:ss");
            double seconds = TimeSpan.Parse(tim).TotalSeconds;
            return seconds;

        }
        //Debug.Log(time);
        // Debug.Log(tim);


    }

}*/
    

