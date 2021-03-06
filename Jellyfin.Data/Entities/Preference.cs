//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor
//     https://github.com/msawczyn/EFDesigner
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Jellyfin.Data.Entities
{
   public partial class Preference
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected Preference()
      {
         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static Preference CreatePreferenceUnsafe()
      {
         return new Preference();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="kind"></param>
      /// <param name="value"></param>
      /// <param name="_user0"></param>
      /// <param name="_group1"></param>
      public Preference(global::Jellyfin.Data.Enums.PreferenceKind kind, string value, global::Jellyfin.Data.Entities.User _user0, global::Jellyfin.Data.Entities.Group _group1)
      {
         this.Kind = kind;

         if (string.IsNullOrEmpty(value)) throw new ArgumentNullException(nameof(value));
         this.Value = value;

         if (_user0 == null) throw new ArgumentNullException(nameof(_user0));
         _user0.Preferences.Add(this);

         if (_group1 == null) throw new ArgumentNullException(nameof(_group1));
         _group1.Preferences.Add(this);


         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="kind"></param>
      /// <param name="value"></param>
      /// <param name="_user0"></param>
      /// <param name="_group1"></param>
      public static Preference Create(global::Jellyfin.Data.Enums.PreferenceKind kind, string value, global::Jellyfin.Data.Entities.User _user0, global::Jellyfin.Data.Entities.Group _group1)
      {
         return new Preference(kind, value, _user0, _group1);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Identity, Indexed, Required
      /// </summary>
      [Key]
      [Required]
      public int Id { get; protected set; }

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public global::Jellyfin.Data.Enums.PreferenceKind Kind { get; set; }

      /// <summary>
      /// Required, Max length = 65535
      /// </summary>
      [Required]
      [MaxLength(65535)]
      [StringLength(65535)]
      public string Value { get; set; }

      /// <summary>
      /// Concurrency token
      /// </summary>
      [Timestamp]
      public Byte[] Timestamp { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

   }
}

