namespace CSharp001
{
    class Book
    {
        public string title;
        public string contents;
        public int page;
        public void Print()
        {
            Console.WriteLine("나는 프린트");       
        }

        public int Num(int a)
        {
           return a;
        }
        public void Write(bool bCheck, string s)
        {
            if (bCheck == false) return;
        }
        // 생성자(constructor)
        // 접근 제한자 클래스이름(매개변수가 있을수도 있고 없을수도 있음)
        // 생성자는 기본적으로 new를 통해 객체를 할당하는 시점에 자동으로 호출한다.
        // 생성자는 매개변수를 가질 수 있다.
        // 만약 정의하지 않는다면 컴파일러가 빈 생성자를 해당 클래스에 알아서 만들어준다.

    }
    class Person
    {
        string _name;

        // 생성자
        public Person()
        {
            Console.WriteLine("생성자 호출");
        }
        // 생성자
        public Person(string name)
        {
            _name = name;
        }
        //소멸자 - gc
        ~Person() 
        {
            
        }
        public void WriteName()
        {
            Console.WriteLine(_name);
        }
    }

    class Unit
    {
        public string name;
        public int hp;
        public int atk;

        public void Print(string name, int hp, int atk)
        {
            Console.WriteLine($"{name}가 등장했다");
            Console.WriteLine($"{name}의 체력 : {hp}");
            Console.WriteLine($"{name}의 공격력 : {atk}");
        }
    }

    internal class Program
    {
        /*
        enum Direction
        {
            left, right, up, down
        }
        */

        static void Main(string[] args)
        {
            /*
            Book book = new Book();

            book.title = "이상한 나라의 앨리스";
            book.contents = "ㅇㅎㅎㅎ";
            book.page = 1;
            book.Print();
            Console.WriteLine(book.title);
            Console.WriteLine(book.contents);
            Console.WriteLine(book.page);
            */

            /*
            Unit orc = new Unit();

            orc.name = "오크";
            orc.hp = 100;
            orc.atk = 10;
            // Console.WriteLine(orc.value);
            // Console.WriteLine(orc.hp);
            // Console.WriteLine(orc.atk);
            orc.Print(orc.name, orc.hp, orc.atk);
            */

            Person person = new Person();
            Person person1 = new Person("철수");
            person1.WriteName();




            /*
            Console.WriteLine("Hello, World!");
            Console.Write("줄바꿈이 안됨");
            Console.WriteLine("오늘부터 C#이야");
            Console.WriteLine("\n"); // escape 시퀀스, 개행
            Console.WriteLine("\t\t"); // tab

            int a=1;

            Console.WriteLine(a);

            Console.WriteLine("경일게임아카데미 : {0}, {1}", "으힛", 1234);

            int num = 1;

            string str = string.Format("경일 : {0}, {1}, {2}", "ddd", 1234, num);

            Console.WriteLine(str);
            
            int a = 10;
            int b = 20;

            Console.WriteLine($"Test : {a} + {b} = {a + b}");   //string 문자열 안에 직접 변수를 넣을 수 있음
            */

            // int
            // float
            // double
            // short
            // bool
            // long
            // uint (unsigned int)
            // char

            /*
             
            Console.WriteLine(sizeof(char));

            char a = '안';
            char b = '녕';
            char c = '하';
            char d = '세';
            char e = '요';
            Console.Write(a);
            Console.Write(b);
            Console.Write(c);
            Console.Write(d);
            Console.Write(e);
            */

            // 배열, 클래스 ...string, object...

            // int i = 0;  //stack영역, 값형식을 가리키는 변수, 변수는 메모리를 가리키는 식별자
            // 값 형식 
            // - stack 
            // 참조형식
            // - heap 
            // stack에는 변수의 주소값 ex) 0x
            // heap에는 0이 들어감 (위 int i 를 예시
            // stack의 변수값은 Heap의 데이터 주소를 가리킴
            // 값 형식은 stack만 이용,
            // 참조 형식은 stack과 heap 둘다 이용(힙 영역에는 데이터를 저장하고 스택영역에는 데이터가 저장된 힙 메모리 주소를 저장)
            // 실제 데이터의 메모리 주소를 참조한다고 해서 참조 형식 

            // object a = 10;  // 참조형식
            // object b = 20;  // 10, 20 은 heap에 저장, a b는 값에 저장된 heap의 주소만 stack에 저장
            // 중괄호가 빠져나가면 stack에서는 값이 날라가고 , heap에 있는것들은 가비지 컬렉터가 수거

            /*
             값형식
            - 변수가 값을 담는 형식
            ㄴ 모두 스택에 저장, 프로그램이 }를 만나면 메모리에서 사라진다.
            참조형식
            -변수가 값 대신 값이 있는 곳의 위치(참조)를 담는 데이터 형식 
            ㄴ 힙과 스택을 함께 사용
            ㄴ 힙 영역에는 데이터를 저장하고, 스택 영역에는 데이터가 저장된 힙 메모리의 주소를 저장한다.
            // gc(가비지컬렉터)
            // gc 단점 : 메모리 회수 타이밍을 모름
            // gc 장점 : 직접 컨트롤 안해도됨
             */

            /*
            const int j = 0;    // 상수 : 바꿀수 없음

            int select;
            select = int.Parse(Console.ReadLine()); // 형변환 , ReadLine은 String 타입
            Console.WriteLine(select);


            int n = 1;
            // 2,3,5의 배수
            while( n <= 1000)
            {
                if (n % 2 != 0) continue;
                if (n % 3 != 0) continue;
                if (n % 5 != 0) continue;
            }
            */

            /*
            // 데이터 형식 [] 배열이름 = new 데이터형식[용량];
            int[] numArr = new int[5];
            numArr[0] = 10;
            numArr[1] = 20;
            numArr[2] = 30;
            numArr[3] = 40;
            numArr[4] = 50;

            int[] numArr1 = new int[3] { 1, 2, 3, };
            Console.WriteLine(numArr1[1]);

            char[] cArr = new char[3];
            cArr[0] = 'a';
            cArr[1] = 'b';
            cArr[2] = 'c';
            */
            // 배열 초기화 방법
            // 1. 배열의 크기를 명시하는 방법 : 명시적으로 알려주는게 좋긴함(협업, 명시하기)

            /*
            string[] str = new string[3] { "서울", "대전", "대구" };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(str[i]);
            }

            // 2. 배열의 크기를 생략하는 방법

            string[] str1 = new string[] { "배열의", "크기를", "생략한다" };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(str1[i]);
            }

            // 3. new 연산자랑 , 크기를 모두 생략하는 방법
            int[] numArr = { 1, 2, 3 };

            for(int i = 0; i < 3; i++) 
            {
                Console.WriteLine(numArr[i]);
            }

            int[,] numArr1 = new int[4, 3];
            numArr1[0, 0] = 1;

            // 배열의 형식과 길이를 명시
            int[,] numArr2 = new int[2, 3];

            // 배열의 길이를 생략
            // int[,] nummArr3 = new int[,];

            //형식과 길이를 모두 생략
            // int[,] numArr4
            */



            // int[] arrNum = new int[] { 1, 2, 3 };

            /*
            for(int i = 0; i < 3; i++) 
            {
                
            }
            */
            // 배열을 순회하면서 각 데이터 요소에 차례대로 접근하도록 해줌
            // 배열의 끝에 도달하면 자동으로 반복이 종료된다
            /*
            foreach(int i in arrNum) // 배열이나 컬렉션에 주로 많이 쓰임
            {
                Console.WriteLine(i);
            }
            */

            /*
            // 배열을 활용해서
            // 아파트 주민수 구하기
            // 1. 각 층에는 3개의 호실만 존재하고 3층만 있음
            // 2. 각 층의 각 호의 가족이 몇명사는지 입력을 받고 배열에 저장
            // 3. 아파트의 총 몇명이 살고 있는지 합을 구하기
            int[,] apart = new int[3 , 3];
            int total = 0;

           for(int i = 0 ; i < 3 ; i++)
            {
                {
                    for (int k =0; k<3; k++)
                    {
                        Console.Write("각 층 호수에 가족은 몇명 살고 있나?{0}층-------{1}호 \t", i+1, k+1);
                        apart[i,k] = int.Parse(Console.ReadLine());
                    }
                }
            }

           
           for(int i = 0 ;i < 3 ; i++)
            {
                for(int k =0; k<3;k++) 
                {
                    total += apart[i,k];
                }
            }
           
           foreach(var item in apart)
            {
                total += item;
            }
            Console.WriteLine($"총 주민수 : {total}명이 살고 있다");
            */


            /*
            ConsoleKeyInfo input = Console.ReadKey(true);

            switch(input.Key) 
            {
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("asdsd");
                    break;
            }
            */

            //Random rand = new Randosm();

            // 책의 구성요소
            // 제목, 내용 , 글쓴이, 페이지

            // 유닛이라는 클래스를 생성한다.
            // 해당클래스 안에 
            // 유닛의 정보를 나타내는 필드를 지정(정보를 나타내는 변수들 ...)
            // 기능을 나타내는 다양한 메서드를 정의하고 
            // Program.cs에 인스턴스를 생성하고 출력

            int[] number = new int[25];

            int dest;
            int sour;
            int temp;

            int save = 24;
            int move;

            Random rand = new Random();

            for(int i = 24; i >= 0; i--)
            {
                number[save - i] = i;
            }

            for(int i = 0; i <200; i++)
            {
                dest = rand.Next(24);
                sour = rand.Next(24);
                temp = number[dest];
                number[dest] = number[sour];
                number[sour] = temp;
            }

            while(true)
            {
                Console.Clear();
                Console.WriteLine("움직여라");

                for(int i = 0; i<number.Length; i++)
                {
                    Console.Write($"{number[i]} \t");

                    if((i+1)%5==0)
                    {
                        Console.WriteLine("\n\n\n");
                    }
                }

                ConsoleKeyInfo inputkey = Console.ReadKey(true);

                switch (inputkey.Key) 
                {
                    case ConsoleKey.LeftArrow:
                        if(save%5==0)
                        {
                            break;
                        }
                        move = number[save];
                        number[save] = number[save - 1];
                        number[save-1] = move;
                        save--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (save % 5 == 4)
                        {
                            break;
                        }
                        move = number[save];
                        number[save] = number[save + 1];
                        number[save + 1] = move;
                        save++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (save / 5 == 0)
                        {
                            break;
                        }
                        move = number[save];
                        number[save] = number[save - 5];
                        number[save - 5] = move;
                        save-=5;
                        break;
                    case ConsoleKey.DownArrow:
                        if (save / 5 == 4)
                        {
                            break;
                        }
                        move = number[save];
                        number[save] = number[save + 5];
                        number[save + 5] = move;
                        save += 5;
                        break;
                }
            }
        }
    }
}
