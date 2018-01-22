import { Injectable } from '@angular/core';
import { Http } from "@angular/http";
import { HttpModule } from '@angular/http/src/http_module';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';

@Injectable()
export class PatientService {
	request: HttpClient;

	constructor(req: HttpClient) {
		this.request = req;
	 }

	getPatients() {
		// return this.request.get('http://localhost/appointoservice/api/patient').toPromise();
		return this.request.get('http://ec2-18-216-243-172.us-east-2.compute.amazonaws.com/appointoservice/api/patient').toPromise();
	}

	// {
    //     "id": 1,
    //     "patFirstName": "John",
    //     "patLastName": "Doe",
    //     "dateofBirth": 19000101,
    //     "addressId": 1
    // }
	addPatient(PatFirstName: string, PatLastName: string, DateOfBirth: number, AddressId: number) {
		const body = {
			patFirstName: PatFirstName,
			patLastName: PatLastName,
			dateofBirth: DateOfBirth,
			addressId: AddressId
		};
		const headers = new HttpHeaders();
		headers.set('Content-Type', 'application/json; charset=utf-8');
		this.request.post(
			// 'http://localhost/appointoservice/api/patient',
			'http://ec2-18-216-243-172.us-east-2.compute.amazonaws.com/appointoservice/api/patient',
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
