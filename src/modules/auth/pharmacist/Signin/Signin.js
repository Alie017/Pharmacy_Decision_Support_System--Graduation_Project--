import React, { useState } from 'react'
import { api } from '../../../../services/api'
import { Link, useNavigate } from 'react-router-dom'
import { toast } from 'react-toastify'
import { useFormik } from 'formik'
import { FaUserMd } from 'react-icons/fa'
import Layout from '../../Layout/Layout'
import styles from './Signin.module.css'

export default function Signin() {
	const navigate = useNavigate()

	const [error, setError] = useState('')

	const [validationError, setValidationError] = useState([])

	const formik = useFormik({
		initialValues: {
			userNameOrEmailAddress: '',
			password: '',
		},
		onSubmit: async values => {
			try {
				const res = await api.post('/TokenAuth/Authenticate', values)

				if (res.data.success) {
					localStorage.setItem('token', `Bearer ${res.data.result.accessToken}`)
					const user = await api.get('/services/app/Session/GetCurrentLoginInformations', {headers: {Authorization: localStorage.getItem('token')}})
					localStorage.setItem('userId', user.data.result.user.id)
					if(user.data.result.user.name == 'admin') {
						navigate('/admin')
					} else {
						navigate('/pharmacist')
					}
					toast.success('Signed in successfully')
				}
			} catch (err) {
				toast.error('Failed to sign in')
				setError(err.response.data.error.message)
				setValidationError(err.response.data.error.validationErrors)
			}
		},
	})

  return (
		<Layout>
			<div className={styles.icon}>
				<FaUserMd />
			</div>
			<h3 className={styles.formTitle}>Sign In</h3>
			{error && <p className='error'>{error}</p>}
			{validationError &&
				validationError.map(err => <p className='error'>{err.message}</p>)}
			<form onSubmit={formik.handleSubmit} className={styles.form}>
				<div className={styles.formGroup}>
					<label htmlFor='emailAddress'>Email</label>
					<input
						type='text'
						name='userNameOrEmailAddress'
						placeholder='Enter your email'
						onChange={formik.handleChange}
						value={formik.values.userNameOrEmailAddress}
					/>
				</div>
				<div className={styles.formGroup}>
					<label htmlFor='password'>Password</label>
					<input
						type='password'
						name='password'
						placeholder='Enter your password'
						onChange={formik.handleChange}
						value={formik.values.password}
					/>
				</div>
				<div className={styles.formGroup}>
					<button>Sign in</button>
				</div>
			</form>
			<div className={styles.divider}>
				<span className={styles.line}></span>
				<span className={styles.text}>or</span>
				<span className={styles.line}></span>
			</div>
			<Link to='/signup/patient' className={styles.signUpAsBtn}>
				Sign up as patient
			</Link>
			<Link
				to='/signup/pharmacist'
				className={`${styles.signUpAsBtn} ${styles.bgDark}`}
			>
				Sign up as pharmacist
			</Link>
			<p className={styles.haveAnAccount}>
				Are you a patient? Click <Link to='/signin/patient'>here</Link>
			</p>
		</Layout>
	)
}
