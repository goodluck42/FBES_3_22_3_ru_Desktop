using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DataCollectionsControls
{

    public class NodeInfo
    {
        public bool IsFolder { get; set; }
        public bool IsLoaded { get; set; }

        public string Path { get; set; }
    }
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _itemsListBox.DisplayMember = "DisplayMember";
            _items = new BindingList<Item>();
            _itemsListBox.DataSource = _items;
            
            _categoryComboBox.Items.Add("Food");
            _categoryComboBox.Items.Add("Tech");
            _categoryComboBox.Items.Add("Sport");
            
            _categoryComboBox.SelectedIndex = 0;

            var baseNode = new TreeNode()
            {
                Text = c_BaseDirectory,
                Tag = new NodeInfo()
                {
                    Path = @"C:\",
                    IsLoaded = false,
                    IsFolder = true
                }
            };
            
            _dataTreeView.Nodes.Add(baseNode);
            
            InitTreeNode(baseNode);
        }


        private void _addItemButton_Click(object sender, EventArgs e)
        {
            if (_itemNameTextBox.Text == string.Empty || _itemQuantityNumericUpDown.Value == 0)
            {
                return;
            }

            try
            {
                Item item = null;

                foreach (var obj in _items)
                {
                    if (_itemNameTextBox.Text == obj.Name)
                    {
                        item = obj;

                        break;
                    }
                }

                if (item != null)
                {
                    item.Quantity += int.Parse(_itemQuantityNumericUpDown.Text);
                }

                else
                {
                    _items.Add(new Item
                    {
                        Name = _itemNameTextBox.Text,
                        Quantity = int.Parse(_itemQuantityNumericUpDown.Text),
                        Cat = _categoryComboBox.SelectedItem.ToString()
                    });
                }

                _itemNameTextBox.Text = string.Empty;
                _itemQuantityNumericUpDown.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, nameof(ex), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void InitTreeNode(TreeNode node, string baseDirectory = c_BaseDirectory)
        {
            try
            {
                var files = Directory.GetFiles(baseDirectory).Select(x => new
                {
                    Name = Path.GetFileName(x),
                    Path = x
                });
                var folders = Directory.GetDirectories(baseDirectory).Select(x =>
                {
                    var split = x.Split('\\');

                    return new
                    {
                        Name = split.Last(),
                        Path = x
                    };
                });

            
                foreach (var folder in folders)
                {
                    node.Nodes.Add(new TreeNode()
                    {
                        Text = folder.Name,
                        Tag = new NodeInfo()
                        {
                            IsFolder = true,
                            IsLoaded = false,
                            Path = folder.Path
                        }
                    });
                }
            
                foreach (var file in files)
                {
                    node.Nodes.Add(new TreeNode()
                    {
                        Text = file.Name,
                        Tag = new NodeInfo()
                        {
                            IsFolder = false,
                            IsLoaded = false,
                            Path = file.Path
                        }
                    });
                }

                var info = node.Tag as NodeInfo;

                if (info != null)
                {
                    info.IsLoaded = true;
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, nameof(ex), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private BindingList<Item> _items;
        
        private const string c_BaseDirectory = @"C:\";
        
        private void _dataTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var info = e.Node.Tag as NodeInfo;

            if (info == null)
            {
                return;
            }

            if (!info.IsFolder)
            {
                Process.Start(info.Path);
                return;
            }

            if (info.IsLoaded)
            {
                return;
            }

            InitTreeNode(e.Node, info.Path);
        }
    }
}