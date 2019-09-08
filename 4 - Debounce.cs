/*
Debounce

Crie uma função chamada debounce que recebe uma função e um intervalo por parâmetro e 
faz com que essa função só possa ser chamada uma vez durante esse intervalo de tempo.

Exemplo:
const fn = debounce(() => console.log("hello world"), 1000) 
// fn() só pode ser chamada uma vez a cada 1000ms

fn() // "hello world"
fn() // nada acontece
fn() // nada acontece

//  1000ms depois

fn() // "hello world"
*/

using System;

namespace Logikoz.Desafios
{
    internal delegate void Call(string x, int y = 1000);

    internal class Debounce
    {
        static readonly DateTime[] times = new DateTime[2];
        public static void Message1(string msg, int delay) => Send(msg, delay, 0);
        public static void Message2(string msg, int delay) => Send(msg, delay, 1);

        private static void Send(string msg, int delay, byte i)
        {
            DateTime time = DateTime.Now;
            if ((time.Ticks - times[i].Ticks) / TimeSpan.TicksPerMillisecond > delay)
            {
                Console.WriteLine(msg);
                times[i] = time;
            }
        }
    }
}
