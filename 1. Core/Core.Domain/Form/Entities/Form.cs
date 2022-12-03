using Core.Domain.Manifest.Entities;
using Core.Domain.Picture.Entities;
using Framework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Form.Entities
{
    public class Form:BaseAggregateRoot
    {
        /*agg
         شامل لیستی از کامپوننت ها
        برای مثال فرم ثبت نام یا فرم استخدام 
        که شامل کامپوننت هایی مثل نام و تاریخ تولد و عکس و ... میباشد*/
        public string Title { get; set; }
        public ICollection<Content<object>> MyProperty { get; set; }
    }
}
