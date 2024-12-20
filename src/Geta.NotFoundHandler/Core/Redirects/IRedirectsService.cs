// Copyright (c) Geta Digital. All rights reserved.
// Licensed under Apache-2.0. See the LICENSE file in the project root for more information

using System;
using System.Collections.Generic;

namespace Geta.NotFoundHandler.Core.Redirects
{
    public interface IRedirectsService
    {
        IEnumerable<CustomRedirect> GetAll();
        IEnumerable<CustomRedirect> GetSaved();
        IEnumerable<CustomRedirect> GetIgnored();
        IEnumerable<CustomRedirect> GetDeleted();
        IEnumerable<CustomRedirect> Search(string searchText);
        void AddOrUpdate(CustomRedirect redirect);
        void AddOrUpdate(IEnumerable<CustomRedirect> redirects);
        void AddDeletedRedirect(string oldUrl);
        void DeleteByOldUrl(string oldUrl);
        void DeleteByOldUrl(IEnumerable<string> oldUrls);
        int DeleteAll();
        int DeleteAllIgnored();
        void DeleteById(Guid id);
        CustomRedirect Get(Guid id);
    }
}
