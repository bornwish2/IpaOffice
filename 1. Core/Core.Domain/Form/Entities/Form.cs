using Core.Domain.Manifest.Entities;
using Framework.Domain.Entities;

namespace Core.Domain.Form.Entities
{
	public class Form : BaseAggregateRoot
    {
		/*agg
         شامل لیستی از کامپوننت ها
        برای مثال فرم ثبت نام یا فرم استخدام 
        که شامل کامپوننت هایی مثل نام و تاریخ تولد و عکس و ... میباشد*/
        public string Title { get;protected set; }
        public ICollection<Guid> ContentIds { get; protected set; }
        private Form()
        {

        }
        private Form(string title)
        {
            Title = title;
        }
     
        public Form CreateForm(string title)
        {
            return new Form(title);
        }
        public void ChangeTitle(long formId)
        {

        }
    
    }
}

