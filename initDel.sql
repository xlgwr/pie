use pie;
select * from [dbo].[plr_batch_mstr]
select * from [dbo].[plr_mstr]
select * from [dbo].[plr_mstr_tran]


select * from  dbo.pi_mstr
select * from  dbo.pi_det

--delete dbo.pi_mstr
--delete dbo.pi_det

update [dbo].[plr_mstr_tran]
set plr_chr01=''
--delete [dbo].[plr_batch_mstr]
--delete [dbo].[plr_mstr]
--delete [dbo].[plr_mstr_tran]
--update [dbo].[pkey_ctl]
--set [ctl_curr]='0'
--where [ctl_curr] > '0'