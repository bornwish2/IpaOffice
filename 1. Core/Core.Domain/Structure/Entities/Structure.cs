using Framework.Domain.Entities;

namespace Core.Domain.Structure.Entities
{
	public class Structure : BaseAggregateRoot
	{
		/*agg
         برای ایجاد قالب یک 
        manifest
        که شامل یک یا چند فرم است
        عناوین قالب میتواند قالب استخدام کارمند باشد 
        و دارای فرم های اطلاعات فردی،اطلاعات شغلی و ... باشد*/
		public string Title { get; set; }
	}
}


