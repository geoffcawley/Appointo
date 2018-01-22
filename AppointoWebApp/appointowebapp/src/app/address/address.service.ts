import { Injectable } from '@angular/core';
import { Http } from "@angular/http";
import { HttpModule } from '@angular/http/src/http_module';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class AddressService {
	request: HttpClient;

	constructor(req: HttpClient) {
		this.request = req;
	 }

	getAddresses() {
		return this.request.get('http://localhost/appointoservice/api/address').toPromise();
	}

	addAddress(AddressLine1: string, AddressLine2: string, City: string, State: string, ZipCode: number) {
		const body = {
			zipCode: ZipCode,
			addressLine1: AddressLine1,
			addressLine2: AddressLine2,
			city: City,
			state: State
		};
		const headers = new HttpHeaders();
		headers.set('Content-Type', 'application/json; charset=utf-8');
		this.request.post(
			'http://localhost/appointoservice/api/rooms',
			 body,
			 {headers: headers}
		).subscribe();
	}

}
