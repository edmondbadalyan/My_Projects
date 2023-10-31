

//1.Игрок кидает три кубика снова и снова, пока в сумме не выпадет число 18. 
//    Программа считает, сколько попыток он сделает, пока не достигнет цели.



Random random = new Random();


int count = 0;
int count2 = 0;



for (int i = 0; i < 300; i++)
{
    int cube_1 = random.Next(1, 7);
    int cube_2 = random.Next(1, 7);
    int cube_3 = random.Next(1, 7);

    Console.WriteLine($"{cube_1},{cube_2},{cube_3}");

    if (cube_1 != 6 && cube_2 != 6 && cube_3 != 6)
        count++;
    if (cube_1 == 6 && cube_2 == 6 && cube_3 == 6)
        count2++;

    Console.WriteLine($"{count},{count2}");


}








