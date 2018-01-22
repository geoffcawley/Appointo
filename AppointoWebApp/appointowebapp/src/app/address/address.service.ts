import { Injectable } from '@angular/core';
import { Http } from "@angular/http";
import { HttpModule } from '@angular/http/src/http_module';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';

@Injectable()
export class AddressService {
	request: HttpClient;

	constructor(req: HttpClient) {
		this.request = req;
	 }

	getAddresses() {
		// return this.request.get('http://localhost/appointoservice/api/address').toPromise();
		return this.request.get('http://ec2-18-216-243-172.us-east-2.compute.amazonaws.com/appointoservice/api/address').toPromise();
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
			// 'http://localhost/appointoservice/api/address',
			'http://ec2-18-216-243-172.us-east-2.compute.amazonaws.com/appointoservice/api/address',
			 body,
			//  {headers: headers}
		).subscribe(
			// (data) => {
			// 	console.log(data);
			// },
			// (err: HttpErrorResponse) => {
			// 	if (err.error instanceof Error) {
			// 		console.log('Client-side error occured.');
			// 	} else {
			// 		console.log('Server-side error occured.');
			// 	}
			// }
		);
	}

}
