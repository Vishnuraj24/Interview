import { Component } from '@angular/core';
import { FileuploadService } from '../../services/fileupload.service';

@Component({
  selector: 'app-fileupload',
  imports: [],
  templateUrl: './fileupload.component.html',
  styleUrl: './fileupload.component.css'
})
export class FileuploadComponent {

  selectedFile: File | null = null;
  uploadMessage = '';


constructor(private fileservice: FileuploadService){}

onFileSelected(event: any) {
  this.selectedFile = event.target.files[0];
}

uploadFile() {
  if (this.selectedFile) {
    this.fileservice.uploadFile(this.selectedFile).subscribe((data: any) => { 
      
      this.uploadMessage = data.message;
      console.log(this.uploadMessage);
    });
  }
}


}
