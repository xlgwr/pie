using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PIE.DAL
{
	/// <summary>
	/// 数据访问类:OCR_mstr
	/// </summary>
	public partial class OCR_mstr
	{
		public OCR_mstr()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(PIE.Model.OCR_mstr model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OCR_mstr(");
			strSql.Append("Ocr_BatchID,Ocr_PackinglistID,Ocr_vend,Ocr_doc_no,Ocr_rcp_date,Ocr_lineID,Ocr_ctnID,Ocr_partno,Ocr_po,Ocr_custpart,Ocr_qty,Ocr_nw,Ocr_gw,Ocr_ref_no,Ocr_ref_no1,Ocr_TTL,Ocr_unitprice,Ocr_status,Ocr_cre_date,Ocr_cre_user)");
			strSql.Append(" values (");
			strSql.Append("@Ocr_BatchID,@Ocr_PackinglistID,@Ocr_vend,@Ocr_doc_no,@Ocr_rcp_date,@Ocr_lineID,@Ocr_ctnID,@Ocr_partno,@Ocr_po,@Ocr_custpart,@Ocr_qty,@Ocr_nw,@Ocr_gw,@Ocr_ref_no,@Ocr_ref_no1,@Ocr_TTL,@Ocr_unitprice,@Ocr_status,@Ocr_cre_date,@Ocr_cre_user)");
			SqlParameter[] parameters = {
					new SqlParameter("@Ocr_BatchID", SqlDbType.VarChar,20),
					new SqlParameter("@Ocr_PackinglistID", SqlDbType.VarChar,30),
					new SqlParameter("@Ocr_vend", SqlDbType.Char,20),
					new SqlParameter("@Ocr_doc_no", SqlDbType.VarChar,20),
					new SqlParameter("@Ocr_rcp_date", SqlDbType.Date,3),
					new SqlParameter("@Ocr_lineID", SqlDbType.Char,6),
					new SqlParameter("@Ocr_ctnID", SqlDbType.VarChar,30),
					new SqlParameter("@Ocr_partno", SqlDbType.VarChar,30),
					new SqlParameter("@Ocr_po", SqlDbType.VarChar,30),
					new SqlParameter("@Ocr_custpart", SqlDbType.VarChar,30),
					new SqlParameter("@Ocr_qty", SqlDbType.VarChar,50),
					new SqlParameter("@Ocr_nw", SqlDbType.VarChar,50),
					new SqlParameter("@Ocr_gw", SqlDbType.VarChar,50),
					new SqlParameter("@Ocr_ref_no", SqlDbType.VarChar,20),
					new SqlParameter("@Ocr_ref_no1", SqlDbType.VarChar,1),
					new SqlParameter("@Ocr_TTL", SqlDbType.Int,4),
					new SqlParameter("@Ocr_unitprice", SqlDbType.Decimal,9),
					new SqlParameter("@Ocr_status", SqlDbType.NVarChar,50),
					new SqlParameter("@Ocr_cre_date", SqlDbType.DateTime),
					new SqlParameter("@Ocr_cre_user", SqlDbType.VarChar,20)};
			parameters[0].Value = model.Ocr_BatchID;
			parameters[1].Value = model.Ocr_PackinglistID;
			parameters[2].Value = model.Ocr_vend;
			parameters[3].Value = model.Ocr_doc_no;
			parameters[4].Value = model.Ocr_rcp_date;
			parameters[5].Value = model.Ocr_lineID;
			parameters[6].Value = model.Ocr_ctnID;
			parameters[7].Value = model.Ocr_partno;
			parameters[8].Value = model.Ocr_po;
			parameters[9].Value = model.Ocr_custpart;
			parameters[10].Value = model.Ocr_qty;
			parameters[11].Value = model.Ocr_nw;
			parameters[12].Value = model.Ocr_gw;
			parameters[13].Value = model.Ocr_ref_no;
			parameters[14].Value = model.Ocr_ref_no1;
			parameters[15].Value = model.Ocr_TTL;
			parameters[16].Value = model.Ocr_unitprice;
			parameters[17].Value = model.Ocr_status;
			parameters[18].Value = model.Ocr_cre_date;
			parameters[19].Value = model.Ocr_cre_user;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(PIE.Model.OCR_mstr model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update OCR_mstr set ");
			strSql.Append("Ocr_BatchID=@Ocr_BatchID,");
			strSql.Append("Ocr_PackinglistID=@Ocr_PackinglistID,");
			strSql.Append("Ocr_vend=@Ocr_vend,");
			strSql.Append("Ocr_doc_no=@Ocr_doc_no,");
			strSql.Append("Ocr_rcp_date=@Ocr_rcp_date,");
			strSql.Append("Ocr_lineID=@Ocr_lineID,");
			strSql.Append("Ocr_ctnID=@Ocr_ctnID,");
			strSql.Append("Ocr_partno=@Ocr_partno,");
			strSql.Append("Ocr_po=@Ocr_po,");
			strSql.Append("Ocr_custpart=@Ocr_custpart,");
			strSql.Append("Ocr_qty=@Ocr_qty,");
			strSql.Append("Ocr_nw=@Ocr_nw,");
			strSql.Append("Ocr_gw=@Ocr_gw,");
			strSql.Append("Ocr_ref_no=@Ocr_ref_no,");
			strSql.Append("Ocr_ref_no1=@Ocr_ref_no1,");
			strSql.Append("Ocr_TTL=@Ocr_TTL,");
			strSql.Append("Ocr_unitprice=@Ocr_unitprice,");
			strSql.Append("Ocr_status=@Ocr_status,");
			strSql.Append("Ocr_cre_date=@Ocr_cre_date,");
			strSql.Append("Ocr_cre_user=@Ocr_cre_user");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@Ocr_BatchID", SqlDbType.VarChar,20),
					new SqlParameter("@Ocr_PackinglistID", SqlDbType.VarChar,30),
					new SqlParameter("@Ocr_vend", SqlDbType.Char,20),
					new SqlParameter("@Ocr_doc_no", SqlDbType.VarChar,20),
					new SqlParameter("@Ocr_rcp_date", SqlDbType.Date,3),
					new SqlParameter("@Ocr_lineID", SqlDbType.Char,6),
					new SqlParameter("@Ocr_ctnID", SqlDbType.VarChar,30),
					new SqlParameter("@Ocr_partno", SqlDbType.VarChar,30),
					new SqlParameter("@Ocr_po", SqlDbType.VarChar,30),
					new SqlParameter("@Ocr_custpart", SqlDbType.VarChar,30),
					new SqlParameter("@Ocr_qty", SqlDbType.VarChar,50),
					new SqlParameter("@Ocr_nw", SqlDbType.VarChar,50),
					new SqlParameter("@Ocr_gw", SqlDbType.VarChar,50),
					new SqlParameter("@Ocr_ref_no", SqlDbType.VarChar,20),
					new SqlParameter("@Ocr_ref_no1", SqlDbType.VarChar,1),
					new SqlParameter("@Ocr_TTL", SqlDbType.Int,4),
					new SqlParameter("@Ocr_unitprice", SqlDbType.Decimal,9),
					new SqlParameter("@Ocr_status", SqlDbType.NVarChar,50),
					new SqlParameter("@Ocr_cre_date", SqlDbType.DateTime),
					new SqlParameter("@Ocr_cre_user", SqlDbType.VarChar,20)};
			parameters[0].Value = model.Ocr_BatchID;
			parameters[1].Value = model.Ocr_PackinglistID;
			parameters[2].Value = model.Ocr_vend;
			parameters[3].Value = model.Ocr_doc_no;
			parameters[4].Value = model.Ocr_rcp_date;
			parameters[5].Value = model.Ocr_lineID;
			parameters[6].Value = model.Ocr_ctnID;
			parameters[7].Value = model.Ocr_partno;
			parameters[8].Value = model.Ocr_po;
			parameters[9].Value = model.Ocr_custpart;
			parameters[10].Value = model.Ocr_qty;
			parameters[11].Value = model.Ocr_nw;
			parameters[12].Value = model.Ocr_gw;
			parameters[13].Value = model.Ocr_ref_no;
			parameters[14].Value = model.Ocr_ref_no1;
			parameters[15].Value = model.Ocr_TTL;
			parameters[16].Value = model.Ocr_unitprice;
			parameters[17].Value = model.Ocr_status;
			parameters[18].Value = model.Ocr_cre_date;
			parameters[19].Value = model.Ocr_cre_user;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OCR_mstr ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public PIE.Model.OCR_mstr GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Ocr_BatchID,Ocr_PackinglistID,Ocr_vend,Ocr_doc_no,Ocr_rcp_date,Ocr_lineID,Ocr_ctnID,Ocr_partno,Ocr_po,Ocr_custpart,Ocr_qty,Ocr_nw,Ocr_gw,Ocr_ref_no,Ocr_ref_no1,Ocr_TTL,Ocr_unitprice,Ocr_status,Ocr_cre_date,Ocr_cre_user from OCR_mstr ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			PIE.Model.OCR_mstr model=new PIE.Model.OCR_mstr();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public PIE.Model.OCR_mstr DataRowToModel(DataRow row)
		{
			PIE.Model.OCR_mstr model=new PIE.Model.OCR_mstr();
			if (row != null)
			{
				if(row["Ocr_BatchID"]!=null)
				{
					model.Ocr_BatchID=row["Ocr_BatchID"].ToString();
				}
				if(row["Ocr_PackinglistID"]!=null)
				{
					model.Ocr_PackinglistID=row["Ocr_PackinglistID"].ToString();
				}
				if(row["Ocr_vend"]!=null)
				{
					model.Ocr_vend=row["Ocr_vend"].ToString();
				}
				if(row["Ocr_doc_no"]!=null)
				{
					model.Ocr_doc_no=row["Ocr_doc_no"].ToString();
				}
				if(row["Ocr_rcp_date"]!=null && row["Ocr_rcp_date"].ToString()!="")
				{
					model.Ocr_rcp_date=DateTime.Parse(row["Ocr_rcp_date"].ToString());
				}
				if(row["Ocr_lineID"]!=null)
				{
					model.Ocr_lineID=row["Ocr_lineID"].ToString();
				}
				if(row["Ocr_ctnID"]!=null)
				{
					model.Ocr_ctnID=row["Ocr_ctnID"].ToString();
				}
				if(row["Ocr_partno"]!=null)
				{
					model.Ocr_partno=row["Ocr_partno"].ToString();
				}
				if(row["Ocr_po"]!=null)
				{
					model.Ocr_po=row["Ocr_po"].ToString();
				}
				if(row["Ocr_custpart"]!=null)
				{
					model.Ocr_custpart=row["Ocr_custpart"].ToString();
				}
				if(row["Ocr_qty"]!=null)
				{
					model.Ocr_qty=row["Ocr_qty"].ToString();
				}
				if(row["Ocr_nw"]!=null)
				{
					model.Ocr_nw=row["Ocr_nw"].ToString();
				}
				if(row["Ocr_gw"]!=null)
				{
					model.Ocr_gw=row["Ocr_gw"].ToString();
				}
				if(row["Ocr_ref_no"]!=null)
				{
					model.Ocr_ref_no=row["Ocr_ref_no"].ToString();
				}
				if(row["Ocr_ref_no1"]!=null)
				{
					model.Ocr_ref_no1=row["Ocr_ref_no1"].ToString();
				}
				if(row["Ocr_TTL"]!=null && row["Ocr_TTL"].ToString()!="")
				{
					model.Ocr_TTL=int.Parse(row["Ocr_TTL"].ToString());
				}
				if(row["Ocr_unitprice"]!=null && row["Ocr_unitprice"].ToString()!="")
				{
					model.Ocr_unitprice=decimal.Parse(row["Ocr_unitprice"].ToString());
				}
				if(row["Ocr_status"]!=null)
				{
					model.Ocr_status=row["Ocr_status"].ToString();
				}
				if(row["Ocr_cre_date"]!=null && row["Ocr_cre_date"].ToString()!="")
				{
					model.Ocr_cre_date=DateTime.Parse(row["Ocr_cre_date"].ToString());
				}
				if(row["Ocr_cre_user"]!=null)
				{
					model.Ocr_cre_user=row["Ocr_cre_user"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Ocr_BatchID,Ocr_PackinglistID,Ocr_vend,Ocr_doc_no,Ocr_rcp_date,Ocr_lineID,Ocr_ctnID,Ocr_partno,Ocr_po,Ocr_custpart,Ocr_qty,Ocr_nw,Ocr_gw,Ocr_ref_no,Ocr_ref_no1,Ocr_TTL,Ocr_unitprice,Ocr_status,Ocr_cre_date,Ocr_cre_user ");
			strSql.Append(" FROM OCR_mstr ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Ocr_BatchID,Ocr_PackinglistID,Ocr_po,Ocr_qty,Ocr_vend,Ocr_rcp_date,Ocr_lineID,Ocr_ctnID,Ocr_partno,Ocr_doc_no,Ocr_custpart,Ocr_nw,Ocr_gw,Ocr_ref_no,Ocr_ref_no1,Ocr_TTL,Ocr_unitprice,Ocr_status,Ocr_cre_date,Ocr_cre_user ");
			strSql.Append(" FROM OCR_mstr ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM OCR_mstr ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Batch_ID desc");
			}
			strSql.Append(")AS Row, T.*  from OCR_mstr T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "OCR_mstr";
			parameters[1].Value = "Batch_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

