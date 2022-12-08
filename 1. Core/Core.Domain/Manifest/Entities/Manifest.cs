using Core.Domain.Form.Entities;
using Core.Domain.Toolkits.ValueObjects;
using Framework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Manifest.Entities
{
    public class Manifest : BaseAggregateRoot
    {
        #region Properties
        public Guid Id { get;protected set; }
        public string Title { get;protected set; }
        public long FormId { get;protected set; }
        public long DispatcherId { get; protected set; }
        public ManifestState State { get;protected set; }
        #endregion

        #region Constructors
        public Manifest(string title, long formId ,long dispatcherId)
        {
            Title = title;
            FormId= formId;
            DispatcherId = dispatcherId;
        }

        private Manifest()
        {

        }
        #endregion

        #region Methods
        public void ChangeTitle(Manifest manifest,string title)
        {
          manifest.Title = title;
        }
        public void SetState(Manifest manifest,ManifestState manifestState)
        {
            manifest.State = manifestState;
        }
        #endregion
    }
}
