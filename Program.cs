using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 김의성_플밍1기__클래서_생성자
{
    internal class Program
    {
        class PoketMon
        {
            public string name;
            private int hp;
            public PoketMon(string _name, int _hp)
            {
                name = _name;
                hp = _hp;
            }
            public void PrintInfo()
            {
                Console.WriteLine($"포켓몬 이름은 {name} 체력은{hp}입니다.");
            }
        }
        class Trainer
        {
            public string name;
            private PoketMon mon1, mon2, mon3, mon4, mon5, mon6;
            private int cont = 0;
            public Trainer(string _name)
            {
                name = _name;
            }
            public void Input(PoketMon poketmon)
            {
                if (cont >= 6)
                {
                    Console.WriteLine("6마리 꽉찼습니다.");
                    return;
                }

                switch (cont)
                {
                    case 0:
                        mon1 = poketmon;
                        mon1.PrintInfo();
                        break;
                    case 1:
                        mon2 = poketmon;
                        mon2.PrintInfo();
                        break;
                    case 2:
                        mon3 = poketmon;
                        mon3.PrintInfo();
                        break;
                    case 3:
                        mon4 = poketmon;
                        mon4.PrintInfo();
                        break;
                    case 4:
                        mon5 = poketmon;
                        mon5.PrintInfo();
                        break;
                    case 5:
                        mon6 = poketmon;
                        mon6.PrintInfo();
                        break;
                }
                cont++;
                Console.WriteLine($"포켓몬 {poketmon.name} 추가되었습니다.");
                Console.WriteLine($"포켓몬은 {cont}마리 입니다.\n");
            }
            public void Name()
            {
                Console.WriteLine($"이름은 {name}입니다.\n");
            }
            static void Main(string[] args)
            {
                Trainer t = new Trainer("포켓몬마스터 김지우");

                PoketMon pi = new PoketMon("피카츄", 50);
                PoketMon ggo = new PoketMon("꼬북이", 80);
                PoketMon kinggubock = new PoketMon("거북왕", 150);
                PoketMon kingfish = new PoketMon("잉어킹", 100);
                PoketMon digeada = new PoketMon("디그다", 60);
                PoketMon cet = new PoketMon("야옹이", 30);
                PoketMon det = new PoketMon("시범용", 20);

                t.Name();

                t.Input(pi);
                t.Input(ggo);
                t.Input(kinggubock);
                t.Input(kingfish);
                t.Input(digeada);
                t.Input(cet);
                t.Input(det);
            }
        }
    }
}
