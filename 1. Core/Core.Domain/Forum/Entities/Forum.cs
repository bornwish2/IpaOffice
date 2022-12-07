namespace Core.Domain.Forum.Entities
{
    public class Forum
    {
        /*agg
        برای دسته بندی فرستنده ها یا گیرنده ها استفاده میشود.
        manifest هایی که در این انجمن ها منتشر شوند ،
        برای تمام اعضای انجمن قابل نمایش هستند*/



        public ICollection<ForumUser> Users { get; set; }

        private Forum() { }

        private Forum(ForumUser user) => Users.Add(user);





    }
}