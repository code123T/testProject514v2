using System;
using System.Collections.Generic;
using System.Threading;

namespace HumanResourcesManagmentSystem.SystemContentData.MenuContent
{
    public static class MenuContent
    {
        public static void MainMenu()
        {
            Console.WriteLine("1.Sorğulama əməliyyatları");
            Thread.Sleep(200);
            Console.WriteLine("2.Yeniləmək əməliyyatları");
            Thread.Sleep(200);
            Console.WriteLine("3.İşə giriş çıxış vaxtlarının qeydi:");
            Thread.Sleep(200);
            Console.WriteLine("4.Çıxış");
            
        }
        public static void QuestionMenuContents()
        {
            List<string> questionMenuList = new List<string> 
            { 
              "Bir işcinin məlumatların göstər", 
              "Bir işçinin məlumatlarının göstərilməsi və həmin ay üzrə iş məlumatların göstərilməsi",
              "Müəyyən bir ünvana görə işçilərin siyahısının görüntülənməsi",
              "İşə qəbul olunan işçilərin sayının illər üzrə bölgüsünün görüntülənməsi",
              "İşə gec gələn işçilərin siyahısı",
              "Müəyyən bir günün əlavə iş qeydlərinin sadalanması",
              "Əsas menyuya qayıt",
              "Çıxış"
            };
            int rowCount = 0;
            foreach (var item in questionMenuList)
            {
                rowCount++;
                Console.WriteLine("{0}.{1}",rowCount,item);
                Thread.Sleep(200); 
            }
        }
        public static void UpdateMenuContents()
        {
            List<string> updateMenuList = new List<string>
            {
              "Yeni işçinin əlavə edilməsi",
              "İşçi məlumatlarının yenilənməsi",
              "Müəyyən bir günün iş qeydlərinin əlavə edilməsi",
              "İşçi məlumatlarının dosyalardan silinməsi",
              "İşçilər faylının ehtiyat nüsxəsinin çıxarılması",
              "Əsas menyuya qayıt",
              "Çıxış"
            };
            int rowCount = 0;
            foreach (var item in updateMenuList)
            {
                rowCount++;
                Console.WriteLine("{0}.{1}", rowCount, item);
                Thread.Sleep(200);
            }
        }
    }
}
