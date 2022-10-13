int x1 = 1;
int y1 = 3;
char symb1 = '*';

Draw(x1, y1, symb1);

int x2 = 4;
int y2 = 5;
char symb2 = '*';

Draw(x2, y2, symb2);
Console.ReadKey();

//процедурный подход повторяющие куски кода переносятся в отдельные функции
//Минусы в том что есть переменные которые связаны и надо помнить что за что отвечает плс код длинный в одном файле

static void Draw(int x, int y, char symbol)
{
    Console.SetCursorPosition(x, y);
    Console.Write(symbol);
}