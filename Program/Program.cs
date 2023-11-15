using System.Runtime.CompilerServices;

namespace Program
{        
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SRP 5대 원칙
            //Monster spider = new Monster("독거미", 10, 100);

            //spider.Patrol();

            //Information information = new Information();

            //information.MonsterInfo(spider);
            #endregion

            #region OCP 5대 원칙
            Marine marine = new Marine();
            Ghost ghost = new Ghost();
            Firebet firebet = new Firebet();

            UnitManager unitManager = new UnitManager();

            unitManager.Commend(marine);
            unitManager.Commend(ghost);
            unitManager.Commend(firebet);
            #endregion
        }
    }      
}
