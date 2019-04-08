using System;

class MyApp {

    static void Main() {

        // string msg = "Hello World";

        // // print "Hello World"
        // Console.WriteLine(msg);

        // lesson #5 ==============================
        // // 文字列、文字
        // string s = "hello";
        // char c = 'a';

        // // 整数値
        // // byte, short, int, long
        // int i = 100;

        // // 浮動小数点数
        // double d = 52342.34;
        // float f = 23.3f

        // // 論理値
        // bool flag = true;

        // // 型推論
        // var x = 5; // int
        // var y = "world"; // string


        // lesson #6 ==============================
        // var x = 10; // int
        // Console.WriteLine(x / 3);
        // Console.WriteLine(x % 3);
        // Console.WriteLine(x / 3.0);
        // Console.WriteLine(x / (double)3);

        // var y = 5;
        // Console.WriteLine(y);
        // y++;
        // Console.WriteLine(y);
        // y--;
        // Console.WriteLine(y);

        // var z = 6;
        // Console.WriteLine(z);
        // z += 10;
        // Console.WriteLine(z);

        // var flag = true;
        // Console.WriteLine(flag);
        // Console.WriteLine(!flag);


        // lesson #7 ==============================
        // Console.WriteLine("hello " + "world");

        // // Console.WriteLine("hello\tworl\nd");

        // var name = "haruspring";
        // var score = 52.3;

        // // Console.WriteLine(string.Format("{0} [{1}]", name, score));
        // // Console.WriteLine($"{name} [{score}]");
        // // Console.WriteLine($"{name, -10} [{score, -10}]");
        // Console.WriteLine($"{name, -10} [{score + 25, 10:0.00}]");


        // lesson #8 ==============================
        // var score = int.Parse(Console.ReadLine());

        // if (score > 80) {
        //     Console.WriteLine("Great!");
        // } else if (score > 60) {
        //     Console.WriteLine("Good!");
        // } else {
        //     Console.WriteLine("...!");
        // }

        // Console.WriteLine((score > 80) ? "Great!" : "...!");


        // lesson #9 ==============================
        // var signal = Console.ReadLine();

        // switch (signal)
        // {
        //     case "red":
        //         Console.WriteLine("Stop!");
        //         break;
        //     case "blue":
        //     case "green":
        //         Console.WriteLine("Go!");
        //         break;
        //     case "yellow":
        //         Console.WriteLine("Caution!");
        //         break;
        //     default:
        //         Console.WriteLine("wrong signal");
        //         break;
        // }


        // lesson #10 ==============================
        var i = 0;
        // while (i < 10) {
        //     Console.WriteLine(i);
        //     i++;
        // }

        do
        {
            Console.WriteLine(i);
            i++;
        } while (i < 10);
    }
}
