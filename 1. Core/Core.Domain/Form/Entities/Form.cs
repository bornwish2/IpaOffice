using Core.Domain.Manifest.Entities;
using Core.Domain.Toolkits.ValueObjects;
using Framework.Domain.Entities;

namespace Core.Domain.Form.Entities
{
	//public class Form : BaseAggregateRoot
 //   {
	//	/*agg
 //        شامل لیستی از کامپوننت ها
 //       برای مثال فرم ثبت نام یا فرم استخدام 
 //       که شامل کامپوننت هایی مثل نام و تاریخ تولد و عکس و ... میباشد*/
 //       public string Title { get;protected set; }
    
 //       private Form()
 //       {

 //       }
 //       public Form(string title)
 //       {
 //           Title = title;
 //       }
 //       #region Methods
 //       public void CreateForm(string title)
 //       {

 //       }
 //       public void ChangeTitle(Form form, string title)
 //       {
 //           form.Title =title;
 //       }
 //       public void DeleteForm(Form form)
 //       {

 //       }
 //       #endregion
 //   }
    public interface IComponent
    {
        
    }
    public class Leaf : BaseAggregateRoot, IComponent 
    {
        public string Name { get; protected set;}
        public ICollection<Guid> ContentIds { get; protected set; }
        public void ChangeName(Leaf leaf, string name)
        {
            leaf.Name = name;
        }
        public void DeleteForm(Leaf leaf)
        {

        }
        public Leaf(string name)
        {
            Name = name;
        }
    }
    public class Composite: BaseAggregateRoot , IComponent
    {
        public string Name { get; protected set;}
        public ICollection<IComponent> components;
        public Composite(string name)
        {
            this.Name = name;
        }
        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }
        public void ChangeName(Composite composite, string name)
        {
            composite.Name = name;
        }
        public void DeleteForm(Composite composite)
        {

        }
    }
}

