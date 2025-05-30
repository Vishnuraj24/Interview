import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class FileuploadService {
  private baseUrl = 'https://localhost:44331/api/fileupload/upload';
  constructor(private client: HttpClient) { }

  uploadFile(file: File) {
    const formData = new FormData();
    formData.append('file', file);
    return this.client.post(this.baseUrl, formData);
  }
  
}
