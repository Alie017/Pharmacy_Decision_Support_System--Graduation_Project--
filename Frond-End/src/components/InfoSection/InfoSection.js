import React, { useState, useEffect } from 'react'
import { api } from '../../services/api'

import InfoCard from '../InfoCard/InfoCard'

import { FaUserMd } from 'react-icons/fa'
import { FaUserInjured } from 'react-icons/fa'
import { FaRegFileAlt } from 'react-icons/fa'
import { FaPills } from 'react-icons/fa'

import styles from './InfoSection.module.css'
import { useSelector } from 'react-redux'

export default function InfoSection() {
	const { theme } = useSelector(state => state.theme)

	const [drugCount, setDrugCount] = useState(0)
	const [documentCount, setDocumentCount] = useState(0)
	const [patientCount, setPatientCount] = useState(0)
	const [pharmacistCount, setPharmacistCount] = useState(0)

	const fetchData = async () => {
		api
			.get('/services/app/Drug/GetListDrug', {
				headers: { Authorization: localStorage.getItem('token') },
			})
			.then(res => setDrugCount(res.data.result.length))

		const documentsResponse = await api.get(
			'/services/app/Document/GetListDocument',
			{ headers: { Authorization: localStorage.getItem('token') } }
		)
		setDocumentCount(documentsResponse.data.result.length)

		const userResponse = await api.get('/services/app/User/GetAll', {headers: {Authorization: localStorage.getItem('token')}})
		let patient = 0
		let pharmacist = 0
		userResponse.data.result.items.forEach(user => {
			if(user.roleNames.includes('PHARMACIST')) {
				pharmacist++
			} else if (user.roleNames.includes('PATIENT')) {
				patient++
			}
		})
		setPharmacistCount(pharmacist)
		setPatientCount(patient)
		// setPatientCount(userResponse.data.result.length)
		// setPharmacistCount(userResponse.data.result.length)
		// console.log(pharmacistCount, patientCount)
	}

	useEffect(() => {
		fetchData()

		return () => {
			console.log('')
		}
	}, [])

  return (
		<div className={`${styles.infoSection} ${theme === 'dark' && styles.dark}`}>
			<h3 className='section-title'>System Information</h3>
			<span className='line'></span>
			<div className={styles.content}>
				<InfoCard
					number={pharmacistCount}
					text='Registered Pharmacist'
					variant='green'
					Icon={FaUserMd}
				/>
				<InfoCard
					number={patientCount}
					text='Registered Patient'
					variant='blue'
					Icon={FaUserInjured}
				/>
				<InfoCard
					number={documentCount}
					text='Registered Report'
					variant='orange'
					Icon={FaRegFileAlt}
				/>
				<InfoCard
					number={drugCount}
					text='Registered Drug'
					variant='yellow'
					Icon={FaPills}
				/>
			</div>
		</div>
	)
}
