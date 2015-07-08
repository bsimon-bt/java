﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
namespace CBinding
{
    static class CBindingMain
    {
        /// <summary>
        /// 
        /// </summary>

        [STAThread]
        static void Main()
        {
            CAPI c = new CAPI("your api key");
            Dictionary<string, Object> cr = null;
            try
            {
                cr = c.Categories("الخميس 5/2/1431 هـ - الموافق 21/1/2010 م (آخر تحديث) الساعة 10:01 (مكة المكرمة)، 7:01 (غرينتش)\n\nناتو يفكر بمسؤول مدني لأفغانستان\n\nيخطط حلف شمال الأطلسي (ناتو) لتعيين مسؤول مدني كبير في أفغانستان، وسط دعوات لتحسين التنسيق السياسي والتنموي في البلاد وفق ما نقلته صحيفة وول ستريت.  وقالت الصحيفة إن السفير البريطاني في كابل في مقدمة المرشحين لهذا المنصب والذي من المحتمل أن يعلن بالتزامن مع مؤتمر دولي عن مستقبل أفغانستان المقرر عقده في لندن في 28 يناير/كانون الثاني المقبل.\n وأضافت الصحيفة -في تقرير لها من كابل- أن المسؤول الجديد سيترأس دعامة مدنية للتحالف الذي تقوده الولايات المتحدة لإدارة التمويل والمساعدات للولايات الأفغانية لتحاشي المؤسسات الأفغانية الفاسدة\".  وكان الأمين العام للأمم المتحدة بان كي مون دعا هذا الشهر لتعيين مسؤول مدني رفيع ضمن قوة المساعدة الدولية لإرساء الأمن في أفغانستان (إيساف) التي يقودها حلف الأطلسي للمساعدة في تنسيق الجهود السياسية والتنموية في الحرب التي دخلت عامها التاسع.  وأضاف أن تعيين هذا المسؤول سيتيح تحسين التنسيق بين العمل السياسي والتنموي وخصوصا عبر فرق إعادة البناء في الولايات الأفغانية.  وقالت جورنال ستريت إن المنصب الجديد سيكون نظيرا للأميركي ستانلي ماكريستال قائد القوات الأميركية وقوات حلف الأطلسي في أفغانستان.  ويتوقع وصول أربعين ألف جندي آخرين لأفغانستان في الأشهر القليلة المقبلة في إطار إستراتيجية لمجابهة العمليات المسلحة لحركة طالبان.  وأشارت الصحيفة إلى أن خطة تعيين السفير البريطاني مارك سيدويل وجدت تأييد الولايات المتحدة ومن المرجح أن يصادق عليها باقي الحلفاء.", "ara", null, "doc", null);
                foreach (string key in cr.Keys)
                {
                    System.Diagnostics.Debug.WriteLine(cr[key].ToString());
                }
            }
            catch(RosetteException e)
            {
                System.Diagnostics.Debug.WriteLine("Error Code " + e.Code.ToString() + ": " + e.Message);
            }

            try
            {
                cr = c.Info();
                foreach (string key in cr.Keys)
                {
                    System.Diagnostics.Debug.WriteLine(cr[key].ToString());
                }
            }
            catch (RosetteException e)
            {
                System.Diagnostics.Debug.WriteLine("Error Code " + e.Code.ToString() + ": " + e.Message);
            }
        }
    }
}
