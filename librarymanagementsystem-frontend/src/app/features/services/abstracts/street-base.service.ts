import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { GetByIdStreetResponse } from '../../models/responses/streets/get-by-id-street-response';
import { environment } from '../../../../environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export abstract class StreetBaseService {
  protected  apiUrl:string = `${environment.API_URL}/Streets`;
  constructor(protected httpClient: HttpClient) { }

  abstract getByIdStreet(id: string): Observable<GetByIdStreetResponse>;
}
