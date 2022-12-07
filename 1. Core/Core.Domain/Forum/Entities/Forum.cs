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


        /// <summary>
        /// Add user to forum
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(User.Entities.User user) => ForumUser.AddUser(user);


        /// <summary>
        /// Update User in Forum
        /// </summary>
        /// <param name="Newuser"></param>
        /// <param name="oldUser"></param>
        public void UpdateUser(ForumUser Newuser, ForumUser oldUser)
        {
            var user = ForumUser.UpadateUser(Newuser, oldUser);
            Users.Remove(oldUser);
            Users.Add(user);
        }


        /// <summary>
        /// remove user frome Forum
        /// </summary>
        /// <param name="User"></param>
        public void RemoveUser(ForumUser User) => Users.Remove(User);

    }
}