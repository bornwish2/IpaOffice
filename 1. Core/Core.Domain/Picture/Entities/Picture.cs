using Core.Domain.Toolkits.ValueObjects;
using Framework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Picture.Entities
{
    public class Picture : BaseAggregateRoot
    {
        #region Properties
        public String Name { get; protected set; }
        public Toolkits.ValueObjects.Path Path { get; protected set; }
        public Description Description { get; protected set; }
        public Guid ContentId { get; set; }
        #endregion

        #region Constructors
        private Picture() { }
        public Picture(Toolkits.ValueObjects.Path path, Description description, string name,Guid contentId)
        {
            Name = name;
            Path = path;
            Description = description;
            ContentId=contentId;
        }
        #endregion

        #region Methods
        public void ChangePath(Picture picture, Toolkits.ValueObjects.Path path)
        {
            picture.Path = path;
        }
        public void ChangeName(Picture picture, string name)
        {
            picture.Name = name;
        }
        public void ChangeDescription(Picture picture, Description description)
        {
            picture.Description = description;
        }
        #endregion
    }
}
