﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace jenkinstest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the jenkinstestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    [RepositoryFolder("2b4b63fb-8964-4019-9412-6005ccaee15e")]
    public partial class jenkinstestRepository : RepoGenBaseFolder
    {
        static jenkinstestRepository instance = new jenkinstestRepository();

        /// <summary>
        /// Gets the singleton class instance representing the jenkinstestRepository element repository.
        /// </summary>
        [RepositoryFolder("2b4b63fb-8964-4019-9412-6005ccaee15e")]
        public static jenkinstestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public jenkinstestRepository() 
            : base("jenkinstestRepository", "/", null, 0, false, "2b4b63fb-8964-4019-9412-6005ccaee15e", ".\\RepositoryImages\\jenkinstestRepository2b4b63fb.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("2b4b63fb-8964-4019-9412-6005ccaee15e")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    public partial class jenkinstestRepositoryFolders
    {
    }
#pragma warning restore 0436
}