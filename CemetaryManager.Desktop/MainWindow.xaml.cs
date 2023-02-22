using CemeteryManager.App.Core.Entities;
using CemeteryManager.App.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CemeteryManager.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly CemeteryManagerAppDbContext _cemeteryManagerAppDbContext;

        public MainWindow(CemeteryManagerAppDbContext cemeteryManagerAppDbContext)
        {
            _cemeteryManagerAppDbContext = cemeteryManagerAppDbContext;
            InitializeComponent();

            var lots = _cemeteryManagerAppDbContext.Lots.AsNoTracking().ToList();
            LotsDataGrid.ItemsSource = lots;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var lotNumber = LotNumber.Text;
            var lotSize = Convert.ToInt32(LotSize.Text);
            var notes = Notes.Text;

            var newLot = new Lot()
            {
                LotNumber = lotNumber,
                LotSize = lotSize,
                Notes = notes
            };

            _cemeteryManagerAppDbContext.Lots.Add(newLot);
            _cemeteryManagerAppDbContext.SaveChanges();
        }
    }
}
