﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataScriptWriter.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DataScriptWriter.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon data_backup {
            get {
                object obj = ResourceManager.GetObject("data_backup", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap if_connect_established_1721 {
            get {
                object obj = ResourceManager.GetObject("if_connect_established_1721", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap if_exit_6035 {
            get {
                object obj = ResourceManager.GetObject("if_exit_6035", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap if_script_lightning_36406 {
            get {
                object obj = ResourceManager.GetObject("if_script_lightning_36406", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DECLARE @Tablename nvarchar(100) = &apos;{0}&apos;;
        ///DECLARE @oid BIGINT = (
        ///SELECT o.object_id from sys.objects o
        ///INNER JOIN sys.schemas s on s.schema_id = o.schema_id
        ///WHERE o.name = parsename(@TableName, 1) and s.name = parsename(@TableName, 2)
        ///);
        ///WITH cc as ( 
        ///    SELECT c.name as COLUMN_NAME, c.is_identity from sys.objects o  
        ///    INNER JOIN sys.columns c ON c.object_id = o.object_id 
        ///    WHERE o.object_id = @oid 
        ///) 
        ///select 	c.ORDINAL_POSITION, c.COLUMN_NAME, c.DATA_TYPE, co.constraint_type, quotename(c [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LoadColumnInfo {
            get {
                return ResourceManager.GetString("LoadColumnInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ;WITH tbs AS
        ///    (
        ///    SELECT s.name AS SchemaName,
        ///           t.name AS TableName,
        ///		   p.rows
        ///    FROM sys.tables t (NOLOCK)
        ///    INNER JOIN sys.schemas s (NOLOCK) ON s.schema_id = t.schema_id
        ///	INNER JOIN sys.partitions p (NOLOCK) ON p.object_id = t.object_id
        ///    WHERE t.is_ms_shipped = 0 
        ///    )
        ///SELECT SchemaName, TableName, SUM(rows) AS RowCnt
        ///FROM tbs
        ///GROUP BY SchemaName, TableName;.
        /// </summary>
        internal static string LoadListOfTables {
            get {
                return ResourceManager.GetString("LoadListOfTables", resourceCulture);
            }
        }
    }
}