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


update [dbo].[plr_mstr_tran]
set plr_chr01=''

--delete dbo.pi_mstr
--delete dbo.pi_det
--delete [dbo].[plr_batch_mstr]
--delete [dbo].[plr_mstr]
--delete [dbo].[plr_mstr_tran]
--update [dbo].[pkey_ctl]
--set [ctl_curr]='0'
--where [ctl_curr] > '0'