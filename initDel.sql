use pie;
select * from [dbo].[plr_batch_mstr]
select * from [dbo].[plr_mstr] where Batch_ID='R1409050027'
select * from [dbo].[plr_mstr_tran] where Batch_ID='R1409040012'

update [dbo].[plr_mstr_tran]
set plr_status='C'
where Batch_ID='R1409040013'
and plr_status<>'U'


select * from  dbo.pi_mstr
select * from  dbo.pi_det
select * from dbo.pisr_grr

select * from plr_mstr_tran where plr_wec_ctn='100000000026'
select * from pi_mstr 
select * from pi_det where pi_wec_ctn='100000000013'

select * from pi_det where PI_ID='P1409180036'
--delete  from pi_det where PI_ID='P1409180036'
--delete from pi_det where pi_wec_ctn='100000000013'

update [dbo].[plr_mstr_tran]
set plr_chr01=''

delete dbo.pi_mstr
delete ticketingPTMR
delete dbo.pi_det
delete [dbo].[plr_batch_mstr]
delete [dbo].[plr_mstr]
delete [dbo].[plr_mstr_tran]
--update [dbo].[pkey_ctl]
--set [ctl_curr]='0'
--where [ctl_curr] > '0'


select a.PI_ID,a.pi_LineID,a.pi_wec_ctn,a.plr_LineID_tran,
	a.pi_pallet_no,a.CartonNo,a.CartonID,a.pi_chr01,
	b.pisr_rir,b.pisr_invoice,b.pisr_part,b.Pisr_receiver,
	b.pisr_site,b.pisr_po_nbr,b.pisr_qty,b.pisr_curr,
	b.pisr_cost,b.pisr_base_cost,b.pisr_us_cost,b.pisr_seq,
	b.pisr_con_code,c.sq_name,b.pisr_net_wt,b.pisr_rec_type,
	b.pisr_abc,b.pisr_code
 from pi_det a 
   left join pisr_grr b 
   on (a.pi_wec_ctn=b.pi_wec_ctn and a.plr_LineID_tran=b.plr_LineID_tran)
   left join pi_sq c
   on (b.pisr_seq = c.sq_id);