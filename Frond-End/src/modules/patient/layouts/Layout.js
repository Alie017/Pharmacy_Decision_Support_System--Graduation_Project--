import React from 'react'
import { useSelector } from 'react-redux'
import { useNavigate } from 'react-router-dom'
import { useQuery } from 'react-query'

import { me } from '../../../services/authService'

import Navbar from './Navbar/Navbar'
import Sidebar from './Sidebar/Sidebar'
import styles from './Layout.module.css'

export default function Layout({ children }) {
	const navigate = useNavigate()

	const result = useQuery('auth/me', me)

	const { theme } = useSelector(state => state.theme)

	if(result.isLoading) {
		<div>Loading...</div>
	}

	if (result.error || !result.data?.data?.result?.user) {
		navigate('/signin/patient')
	} else {
		return (
		<>
			<Navbar />
			<main
				className={`${styles.container} ${theme === 'dark' && styles.dark}`}
			>
				<Sidebar />
				<div className={styles.content}>{children}</div>
			</main>
		</>
	)
	}
}