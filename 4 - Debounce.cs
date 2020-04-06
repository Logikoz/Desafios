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
using System.Collections.Generic;
using System.Linq;

namespace Logikoz.Desafios
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Debounce.Send(new NewAction(() => Console.WriteLine("c# the best"), Guid.Parse("38C7D896-0C11-4D23-A257-A7DF749D2B13")), 3000);
                Debounce.Send(new NewAction(() => Console.WriteLine("outra action"), Guid.Parse("195A1A0F-D61D-4A32-AF65-67E39158785E")), 500);
                Debounce.Send(new NewAction(() => Console.WriteLine("iae"), Guid.Parse("1489D2D5-C88D-4801-B322-A3478D25F04E")), 1000);
            }
        }
    }

    internal class Debounce
    {
        private static readonly List<DateTime> times = new List<DateTime>();
        private static readonly List<NewAction> actions = new List<NewAction>();

        internal static void Send(NewAction action, int delay)
        {
            DateTime time = DateTime.Now;
            if (!actions.Any(a => a.Id == action.Id))
            {
                NewAction(action, time);
                return;
            }
            if (actions.SingleOrDefault(a => a.Id == action.Id) is NewAction currentAction)
            {
                int index = actions.IndexOf(currentAction);
                if ((time.Ticks - times[index].Ticks) / TimeSpan.TicksPerMillisecond > delay)
                {
                    times.RemoveAt(index);
                    actions.RemoveAt(index);
                    NewAction(action, time);
                }
            }

            static void NewAction(NewAction action, DateTime time)
            {
                action.Action.Invoke();
                times.Add(time);
                actions.Add(action);
            }
        }
    }

    internal class NewAction
    {
        internal Guid Id { get; }
        internal Action Action { get; }

        public NewAction(Action action, Guid guid)
        {
            Id = guid;
            Action = action;
        }
    }
}
