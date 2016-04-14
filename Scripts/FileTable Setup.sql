-- Run if needed, but it shouldn't be.
alter database ASPEntityTestBed
remove filegroup Attachments
go

-- Add filegroup
alter database ASPEntityTestBed
add filegroup Attachments contains filestream;
go

alter database ASPEntityTestBed
add file
  ( NAME = 'Attachments', FILENAME = 'c:\FileStream\Attachments'
   )
to filegroup Attachments;
go

-- Alter table for FileTable
alter database ASPEntityTestBed
set FILESTREAM ( NON_TRANSACTED_ACCESS=FULL, Directory_Name = N'Attachments');

create table Attachments AS FileTable
	with (Filetable_Directory='Attachments')


create view AttachmentsView as 
	select stream_id, file_stream, name from dbo.Attachments
go