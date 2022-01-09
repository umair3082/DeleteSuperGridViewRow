 public void DeleteSuperGridViewRow(SuperGridControl superGrid)
        {
            GridPanel panel = superGrid.PrimaryGrid;
            if (panel.SelectedRowCount > 0)
            {
                foreach (GridRow row in panel.SelectedRows)
                {
                    panel.Rows.RemoveAt(row.Index);
                }

            }
        }
        
        
        
private void superGridControl2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Delete)
            {
                cc.DeleteSuperGridViewRow(superGridControl2);
            }
        }        
