using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlameTradeSS
{
    internal class DgvOperations
    {

        public DataGridView ConfigureDgv(DataGridView dgv, FlameTradeDbEntities db,DocumentSequences sequences, DocumentTransactions documentTransactions)
        {
            string doctrams = null;
            List<DocumentSequencesProperties> documentSequencesProperties;
            if (documentTransactions.TransactionTypeID==0)
            {
                 documentSequencesProperties = db.DocumentSequencesProperties.Where(dsp => dsp.DocumentSequenceID == sequences.ID && dsp.TransactonTypeID == null).ToList();

            } else
            {
                documentSequencesProperties = db.DocumentSequencesProperties.Where(dsp => dsp.DocumentSequenceID == sequences.ID && dsp.TransactonTypeID == documentTransactions.TransactionTypeID).ToList();

            }

            List<DgvFields> dgvFields = db.DgvFields.Where(df => df.DataGridViewName == dgv.Name).ToList();
            List<DocumentSequencesProperties> sequencesDgvFields = new List<DocumentSequencesProperties>();

            foreach(DocumentSequencesProperties properties in documentSequencesProperties)
            {
                foreach(DgvFields fields in dgvFields)
                {
                    if (fields.ID == properties.DgvFieldsID)
                    {
                        sequencesDgvFields.Add(properties);
                    }
                }
            }

            foreach(DataGridViewColumn column in dgv.Columns)
            {
                foreach(DocumentSequencesProperties properties in sequencesDgvFields) 
                {
                    if (column.Name == properties.DgvFields.FieldName)
                    {
                        if (properties.InVisible == 0)
                        {
                            column.Visible = true;
                        } else
                        {
                            column.Visible = false;
                        }
                            
                        if (properties.Disabled == 0)
                        {
                            
                        }

                        if (properties.ReadOnly == 0)
                        {
                            column.ReadOnly = false;
                        } else
                        {
                            column.ReadOnly = true;
                        }
                    }
                }
            }
            return dgv;
        }
    }
}
