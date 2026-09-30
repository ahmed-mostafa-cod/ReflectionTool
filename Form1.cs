using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ddlExplore
{
    public partial class Form1 : Form
    {
        Assembly externalAssembly = null;
        Type selectedType = null;
        List<MyMethodItem> MethodList;
        List<MyProperties> ListProperties;
        List<MyClass> allClasses = new List<MyClass>();
        List<MyParameterItem> ParemList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "DLL Files (*.dll)|*.dll|All Files (*.*)|*.*";
            string selectedFilePath = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                selectedFilePath = openFileDialog1.FileName;
            }
            txtdllFile.Text = selectedFilePath;

            ReflectionDDL();
        }

        private void ReflectionDDL()
        {
            if (txtdllFile.Text.Trim() == "")
                return;

            externalAssembly = Assembly.LoadFrom(txtdllFile.Text);



            allClasses = externalAssembly.GetTypes()
                                             .Where(t => t.IsClass && !t.IsAbstract)
                                             .Select(t => new MyClass { Name=t.FullName})
                                            .OrderBy(c => c.Name)
                                             .ToList();
            //classNames.Insert(0, new MyClass { Name = "" });
            dgvClass.DataSource = allClasses;

            dgvClass.Columns[0].HeaderText = "Class";
            dgvClass.Columns[0].Width = 344;
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && externalAssembly != null)
            {
                var selectedItem = dgvClass.Rows[e.RowIndex].DataBoundItem as MyClass;
                if (selectedItem != null && !string.IsNullOrEmpty(selectedItem.Name))
                {
                    string fullClassName = selectedItem.Name;

                    selectedType = externalAssembly.GetType(fullClassName);
                    if (selectedType != null)
                    {
                        var methods = selectedType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly)
                                          .Where(m => !m.IsSpecialName);

                         MethodList = new List<MyMethodItem>();

                        foreach (var method in methods)
                        {
                            MethodList.Add(new MyMethodItem { MethodName = method.Name });
                        }
                        dgvMethod.DataSource = MethodList;
                        dgvMethod.Columns[0].HeaderText = "Methods";
                        dgvMethod.Columns[0].Width = 344;


                        var properties = selectedType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);

                        ListProperties = new List<MyProperties>();

                        foreach (var property in properties)
                        {
                            ListProperties.Add(new MyProperties { Name = property.Name });
                        }
                        dgvProperties.DataSource = ListProperties;
                        dgvProperties.Columns[0].HeaderText = "Properties";
                        dgvProperties.Columns[0].Width = 344;
                    }
                }
            }

            
        }

        private void dgvMethod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0&&selectedType!=null)
            {
                var selectedMethodItem = dgvMethod.Rows[e.RowIndex].DataBoundItem as MyMethodItem;

                if(selectedMethodItem != null)
                {
                    MethodInfo methodInfo = selectedType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly)
                                                .FirstOrDefault(m => m.Name == selectedMethodItem.MethodName && !m.IsSpecialName);
                    if( methodInfo != null )
                    {
                        lblMethodName.Text = methodInfo.Name;
                        lblReturnType.Text=methodInfo.ReturnType.Name;
                        lblIsStatic.Text = methodInfo.IsStatic ? "True" : "False";
                        lblParemters.Text=methodInfo.GetParameters().Length.ToString();
                        if (methodInfo.DeclaringType != null)
                        {
                            lblDecleringType.Text = methodInfo.DeclaringType.FullName;
                        }
                        string accessMod = "Private";
                        if (methodInfo.IsPublic) accessMod = "Public";
                        else if (methodInfo.IsPrivate) accessMod = "Private";
                        else if (methodInfo.IsFamily) accessMod = "Protected";
                        else if (methodInfo.IsAssembly) accessMod = "Internal";
                        lblAccessModifiers.Text = accessMod;

                        var Paremters=methodInfo.GetParameters();
                        ParemList= new List<MyParameterItem>();

                        foreach (var parem in Paremters)
                        {
                            ParemList.Add(new MyParameterItem
                            {
                                ParameterName = parem.Name,
                                ParameterType = parem.ParameterType.Name
                            });
                        }

                        dgvParemters.DataSource = ParemList;

                        dgvParemters.Columns[0].HeaderText = "Type";
                        dgvParemters.Columns[0].Width = 172;

                        dgvParemters.Columns[1].HeaderText= "Name";
                        dgvParemters.Columns[1].Width = 172;
                    }
                }
            }

        
        }

        private void dgvProperties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && selectedType != null)
            {
                var selectedPropItem = dgvProperties.Rows[e.RowIndex].DataBoundItem as MyProperties;
                if (selectedPropItem != null)
                {
                    PropertyInfo propInfo = selectedType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly)
                                                 .FirstOrDefault(p => p.Name == selectedPropItem.Name);

                    if (propInfo != null)
                    {
                        lblPropertiesName.Text = propInfo.Name;

                        MethodInfo accessor = propInfo.GetGetMethod(true) ?? propInfo.GetSetMethod(true);
                        string accessMod = "Private";

                        if (accessor != null)
                        {
                            if (accessor.IsPublic) accessMod = "Public";
                            else if (accessor.IsPrivate) accessMod = "Private";
                            else if (accessor.IsFamily) accessMod = "Protected";
                            else if (accessor.IsAssembly) accessMod = "Internal";
                        }
                        lblAccessProperties.Text = accessMod;

                      
                        lblCanRead.Text = propInfo.CanRead.ToString();
                        lblCanWrite.Text = propInfo.CanWrite.ToString();

                      
                        if (propInfo.DeclaringType != null)
                        {
                            lblPropertiesDecleringType.Text = propInfo.DeclaringType.FullName;
                        }

                        bool isStatic = accessor != null && accessor.IsStatic;
                        lblPropertiesIsStatic.Text = isStatic ? "True" : "False";
                      

                      
                    }

                }
                
            }
        }

        private void txtSearchClass_TextChanged(object sender, EventArgs e)
        {
            if (allClasses == null || allClasses.Count == 0) return;
            string searchTest = txtSearchClass.Text.Trim();

            if(string.IsNullOrEmpty(searchTest))
            {
                dgvClass.DataSource = allClasses;

            }
            else
            {
                var filtered = allClasses.Where(c => c.Name.ToLower().Contains(searchTest)).ToList();
                dgvClass.DataSource = filtered;
            }
        }

        private void txtMethod_TextChanged(object sender, EventArgs e)
        {
            if(MethodList==null || MethodList.Count == 0) { return; }

            var searchText=txtMethod.Text.Trim().ToLower();
            if(string.IsNullOrEmpty(searchText))
            {
                dgvMethod.DataSource = MethodList;
            }
            else
            {
                var filtered = allClasses.Where(m => m.Name.ToLower().Contains(searchText)).ToList();
              dgvMethod.DataSource = filtered;
            }
        }

        private void txtProperties_TextChanged(object sender, EventArgs e)
        {
            if (ListProperties == null || ListProperties.Count == 0) return;

            string searchText=txtProperties.Text.Trim().ToLower();
            if(string.IsNullOrEmpty(searchText))
            {
                dgvProperties.DataSource = ListProperties;
            }
            else
            {
                var filtered = allClasses.Where(p => p.Name.ToLower().Contains(searchText)).ToList();
                dgvProperties.DataSource = filtered;
            }
        }
    }
    public class MyClass
    {
        public string Name { get; set; }
    }

    public class MyMethodItem
    {
        public string MethodName { get; set; }
    }
    public class MyProperties
    { public string Name { get; set; }}

    public class MyParameterItem
    {
        public string ParameterName { get; set; }
        public string ParameterType { get; set; }
    }


}
