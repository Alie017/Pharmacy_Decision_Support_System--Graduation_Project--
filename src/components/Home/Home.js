import React from 'react'
import { Link } from 'react-router-dom'
import pharmacistBg from '../../assets/pharmacistBg.jpg'
import patientBg from '../../assets/patientBg.jpg'
import styles from './Home.module.css'

export default function Home() {
  return (
		<div className={styles.row}>
			<div>
				<img src={patientBg} alt='image' />
				<Link to='/signin/patient'>Sign In as Patient</Link>
			</div>
			<div>
				<img src={pharmacistBg} alt='image' />
				<Link to='/signin/pharmacist'>Sign In as Pharmacist</Link>
			</div>
		</div>
	)
}
